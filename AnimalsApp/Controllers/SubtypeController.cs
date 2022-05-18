using Microsoft.AspNetCore.Mvc;

namespace AnimalsApp.Controllers;

[Route("subtypes")]
[ApiController]
public class SubtypeController:ControllerBase
{
    private static IEnumerable<Subtype> _subtypes = new[]
    {
        new Subtype
        {
            Id = 1,
            Name = "British fold",
            BeastName = "Cats"
        },
        new Subtype
        {
            Id = 2,
            Name = "Shepherd dog",
            BeastName = "Dogs"
        },
        new Subtype
        {
            Id = 3,
            Name = "Polar wolf",
            BeastName = "Wolfs"
        }
    };
    
    private readonly ILogger<SubtypeController> _logger;
    
    public SubtypeController(ILogger<SubtypeController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet]
    public IEnumerable<Subtype> Get()
    {
        return _subtypes.ToArray();
    }
}