using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ActivosBackend.Data;
using ActivosBackend.Models;

namespace ActivosBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        // Inyección de dependencias para acceder a la base de datos
        public CategoriasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Endpoint GET: api/categorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriaActivo>>> GetCategorias()
        {
            return await _context.CategoriasActivo.ToListAsync();
        }
    }
}