using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using playkidsAPI.Data;
using playkidsEntidades;
using System.Data;

namespace playkidsAPI.Controllers.Sp
{
    [Route("api/sp/usuarios")]
    [ApiController]
    public class UsuariosSpController : ControllerBase
    {
        private readonly DbContextSistema _context;
        private readonly string _connectionString;

        public UsuariosSpController(DbContextSistema context, IConfiguration configuration)
        {
            _context = context;
            _connectionString = configuration.GetConnectionString("ConexionPlayKids") ?? string.Empty;
        }

        // 1. GET: api/sp/usuarios (Listar usando sp_ObtenerTodosLosUsuarios)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuariosSp()
        {
            var lista = new List<Usuario>();

            using (var conexion = new SqlConnection(_connectionString))
            {
                await conexion.OpenAsync();
                using (var comando = new SqlCommand("sp_ObtenerTodosLosUsuarios", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    using (var lector = await comando.ExecuteReaderAsync())
                    {
                        while (await lector.ReadAsync())
                        {
                            lista.Add(new Usuario
                            {
                                IdUsuario = lector.GetInt32(lector.GetOrdinal("IdUsuario")),
                                Nombre = lector.GetString(lector.GetOrdinal("Nombre")),
                                Edad = lector.GetInt32(lector.GetOrdinal("Edad")),
                                Sexo = lector.GetString(lector.GetOrdinal("Sexo")),
                                Correo = lector.GetString(lector.GetOrdinal("Correo")),
                                Contrasena = lector.GetString(lector.GetOrdinal("Contrasena")),
                                IdRol = 3 
                            });
                        }
                    }
                }
            }

            return Ok(lista);
        }

        // 2. POST: api/sp/usuarios (Insertar usando sp_InsertarUsuario)
        [HttpPost]
        public async Task<IActionResult> PostUsuarioSp(Usuario usuario)
        {
            using (var conexion = new SqlConnection(_connectionString))
            {
                await conexion.OpenAsync();
                using (var comando = new SqlCommand("sp_InsertarUsuario", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@Edad", usuario.Edad);
                    comando.Parameters.AddWithValue("@Sexo", usuario.Sexo);
                    comando.Parameters.AddWithValue("@Correo", usuario.Correo);
                    comando.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);

                    // Usamos ExecuteNonQuery y leemos con CommandBehavior.CloseConnection si hace falta, 
                    // o simplemente dejamos que el SP ejecute el INSERT limpio.
                    await comando.ExecuteNonQueryAsync();
                }
            }

            return Ok(new { mensaje = "Usuario registrado correctamente mediante Procedimiento Almacenado" });
        }
    }
}