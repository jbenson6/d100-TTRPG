using Microsoft.AspNetCore.Mvc;
using d100_TTRPG.Data_Objects.PowerLevel;

namespace d100_TTRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PowerLevelsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var fields = typeof(PowerLevelDb).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            var items = fields
                .Select(f => f.GetValue(null))
                .OfType<PowerLevelDefinition>()
                .Select(p => new {
                    Name = p.Level.ToString(),
                    Points = p.Points,
                    Features = p.Features,
                    Description = p.Description
                })
                .OrderBy(x => x.Name)
                .ToList();

            return Ok(items);
        }
    }
}
