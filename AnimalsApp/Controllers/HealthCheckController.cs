using Microsoft.AspNetCore.Mvc;

namespace AnimalsApp.Controllers;

[ApiController]
[Route("hc")]
public class HealthCheckController:ControllerBase
{
    private readonly ILogger<HealthCheckController> _logger;

    public HealthCheckController(ILogger<HealthCheckController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}