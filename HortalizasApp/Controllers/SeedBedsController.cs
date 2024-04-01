using HortalizasApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace HortalizasApp.Controllers;

[ApiController]
public class SeedBedsController : Controller
{
    private readonly ISeedBedRepository _seedBedRepository;
    
    public SeedBedsController(ISeedBedRepository seedBedRepository)
    {
        _seedBedRepository = seedBedRepository;
    }
    
    [HttpGet("/hortalizas")]
    public async Task<IActionResult> GetHortalizas()
    {
        var beds = await _seedBedRepository.GetBeds();
        
        return Ok(beds);
    }
}