using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Text.Json;
using System.IO;

namespace playkidsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogrosPythonController : ControllerBase
    {
        private readonly string _connectionString;
        private readonly IConfiguration _configuration;

        public LogrosPythonController(IConfiguration configuration)
        {
            _configuration = configuration;
            // Configuración alineada correctamente con appsettings.json
            _connectionString = _configuration.GetConnectionString("ConexionPlayKids")
                ?? "Server=.\\PLAYKIDS;Database=PlayKidsCapasDB;Trusted_Connection=True;TrustServerCertificate=True;";
        }

        [HttpGet("{idUsuario}")]
        public async Task<IActionResult> ObtenerLogrosArbol(int idUsuario)
        {
            try
            {
                var listaLogros = new List<object>();

                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    using (SqlCommand cmd = new SqlCommand("sp_ObtenerYActualizarLogrosUsuario", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                listaLogros.Add(new
                                {
                                    id_logro = Convert.ToInt32(reader["IdLogro"]),
                                    titulo = reader["Titulo"].ToString(),
                                    descripcion = reader["Descripcion"].ToString(),
                                    completado = Convert.ToBoolean(reader["Completado"])
                                });
                            }
                        }
                    }
                }

                string jsonLogros = JsonSerializer.Serialize(listaLogros);
                string jsonEscapado = jsonLogros.Replace("\"", "\\\"");

                string scriptPath = Path.Combine(AppContext.BaseDirectory, "arbol_logros.py");
                if (!System.IO.File.Exists(scriptPath))
                {
                    scriptPath = Path.Combine(Directory.GetCurrentDirectory(), "arbol_logros.py");
                }

                if (!System.IO.File.Exists(scriptPath))
                {
                    return StatusCode(404, new { mensaje = $"No se encontró el script en: {scriptPath}" });
                }

                // Pasamos el JSON como primer argumento y el idUsuario como segundo argumento para aislar el PNG
                var startInfo = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = $"\"{scriptPath}\" \"{jsonEscapado}\" \"{idUsuario}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = Process.Start(startInfo))
                {
                    if (process == null)
                        return StatusCode(500, new { mensaje = "No se pudo iniciar el proceso de Python." });

                    string resultadoJson = await process.StandardOutput.ReadToEndAsync();
                    string error = await process.StandardError.ReadToEndAsync();
                    await process.WaitForExitAsync();

                    if (!string.IsNullOrEmpty(error) && !resultadoJson.StartsWith("["))
                    {
                        return StatusCode(500, new { mensaje = "Error en Python", error });
                    }

                    var datosJson = JsonSerializer.Deserialize<object>(resultadoJson);
                    return Ok(datosJson);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Excepción al procesar los logros", detalle = ex.Message });
            }
        }

        // Endpoint dedicado y seguro por usuario para devolver su propia imagen PNG generada por Python
        [HttpGet("/arbol_logros/{idUsuario}.png")]
        public IActionResult ObtenerImagenArbol(int idUsuario)
        {
            string imageName = $"arbol_logros_{idUsuario}.png";
            string imagePath = Path.Combine(AppContext.BaseDirectory, imageName);
            if (!System.IO.File.Exists(imagePath))
            {
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), imageName);
            }

            if (!System.IO.File.Exists(imagePath))
            {
                return NotFound(new { mensaje = "La imagen del árbol para este usuario aún no ha sido generada." });
            }

            var fileBytes = System.IO.File.ReadAllBytes(imagePath);
            return File(fileBytes, "image/png");
        }
    }
}