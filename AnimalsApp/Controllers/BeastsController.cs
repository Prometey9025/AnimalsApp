using Microsoft.AspNetCore.Mvc;

namespace AnimalsApp.Controllers;

[Route("beasts")]
[ApiController]
public class BeastsController:ControllerBase
{
    private static IEnumerable<Beasts> _beasts = new[]
    {
        new Beasts
        {
            Id = 1,
            Name = "Cats"
        },
        new Beasts
        {
            Id = 2,
            Name = "Dogs"
        },
        new Beasts
        {
            Id = 3,
            Name = "Wolfs"
        },
    };
    
    private readonly ILogger<BeastsController> _logger;
    
    public BeastsController(ILogger<BeastsController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet]
    public IEnumerable<Beasts> Get()
    {
        return _beasts.ToArray();
    }
}