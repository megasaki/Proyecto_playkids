using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using playkidsAPI.Data;
using playkidsEntidades;

namespace playkidsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly DbContextSistema _context;

      
        public UsuariosController(DbContextSistema context)
        {
            _context = context;
        }

       
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            var listaUsuarios = await _context.Usuario.ToListAsync();
            return Ok(listaUsuarios);
        }
    }
}