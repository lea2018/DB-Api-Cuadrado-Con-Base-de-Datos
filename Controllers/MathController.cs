using Microsoft.AspNetCore.Mvc;

namespace MiApiCuadrado.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MathController : ControllerBase
{
    [HttpGet("cuadrado/{numero:int}")]
    public IActionResult Cuadrado(int numero)
    {
        if (numero < 0)
            return BadRequest("El numero debe ser mayor o igual a 0.");

        return Ok($"La raiz cuadrada de {numero} es {numero * numero}");
    }
}