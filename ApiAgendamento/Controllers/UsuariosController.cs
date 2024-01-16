using ApiAgendamento.Context;
using ApiAgendamento.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiAgendamento.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UsuarioModel>> Get()
        {
            var usuarios = _context.UsuarioModel.ToList();

            if (usuarios is null)
            {
                return NotFound();
            }

            return Ok(usuarios);
        }
    }
}
