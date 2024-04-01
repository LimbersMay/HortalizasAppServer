using HortalizasApp.Models;
using HortalizasApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace HortalizasApp.Controllers;

[ApiController]
public class HortalizasController : Controller
{
    private readonly IBedRepository _bedRepository;
    
    public HortalizasController(IBedRepository bedRepository)
    {
        _bedRepository = bedRepository;
    }
    
    [HttpGet("/hortalizas")]
    public async Task<IActionResult> GetHortalizas()
    {
        var beds = await _bedRepository.GetBeds();
        
        return Ok(beds);
    }
}