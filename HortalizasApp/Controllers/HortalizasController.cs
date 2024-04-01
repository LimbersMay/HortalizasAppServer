using Microsoft.AspNetCore.Mvc;

namespace HortalizasApp.Controllers;

[ApiController]
public class HortalizasController : Controller
{
    [HttpGet("/hortalizas")]
    public IActionResult GetHortalizas()
    {
        return Ok(new
        {
            name = "Tomate",
            description = "Tomate de la mejor calidad",
        });
    }
}