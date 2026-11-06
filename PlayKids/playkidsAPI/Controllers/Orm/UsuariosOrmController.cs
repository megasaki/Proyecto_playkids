using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using playkidsAPI.Data;
using playkidsEntidades;

namespace playkidsAPI.Controllers.Orm
{
    [Route("api/orm/usuarios")]
    [ApiController]
    public class UsuariosOrmController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public UsuariosOrmController(DbContextSistema context)
        {
            _context = context;
        }

        // 1. GET: api/orm/usuarios (Listar todos)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            return await _context.Usuario.ToListAsync();
        }

        // 2. GET: api/orm/usuarios/5 (Buscar por ID)
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _context.Usuario.FindAsync(id);

            if (usuario == null)
            {
                return NotFound(new { mensaje = "Usuario no encontrado" });
            }

            return usuario;
        }

        // 3. POST: api/orm/usuarios (Crear nuevo usuario con contraseña encriptada)
        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            // Encriptar la contraseña en SHA256 antes de guardarla
            usuario.Contrasena = EncriptarSha256(usuario.Contrasena);

            _context.Usuario.Add(usuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUsuario), new { id = usuario.IdUsuario }, usuario);
        }

        // Método auxiliar actualizado para evitar el aviso de Obsoleto
        private string EncriptarSha256(string texto)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(texto));
                string hash = string.Empty;
                foreach (byte b in bytes)
                {
                    hash += b.ToString("x2");
                }
                return hash;
            }
        }   

        // 4. PUT: api/orm/usuarios/5 (Actualizar usuario)
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(int id, Usuario usuario)
        {
            if (id != usuario.IdUsuario)
            {
                return BadRequest(new { mensaje = "El ID del usuario no coincide" });
            }

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Usuario.Any(e => e.IdUsuario == id))
                {
                    return NotFound(new { mensaje = "Usuario no encontrado para actualizar" });
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // 5. DELETE: api/orm/usuarios/5 (Eliminar usuario)
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario == null)
            {
                return NotFound(new { mensaje = "Usuario no encontrado para eliminar" });
            }

            _context.Usuario.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}