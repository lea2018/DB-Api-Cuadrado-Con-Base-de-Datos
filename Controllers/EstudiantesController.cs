using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiApiCuadrado.Data;
using MiApiCuadrado.Models;

namespace MiApiCuadrado.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstudiantesController : ControllerBase
    {
        private readonly DBApiCuadradoContext _context;

        public EstudiantesController(DBApiCuadradoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerEstudiantes()
        {
            var estudiantes = await _context.Estudiantes.ToListAsync();

            return Ok(estudiantes);
        }
    }
}