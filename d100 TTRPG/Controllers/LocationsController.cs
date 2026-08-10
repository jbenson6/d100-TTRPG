using Microsoft.AspNetCore.Mvc;
using d100_TTRPG.Data_Objects.Location;

namespace d100_TTRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var fields = typeof(LocationDb).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            var items = fields
                .Select(f => f.GetValue(null))
                .OfType<LocationDefinition>()
                .Select(ld => new
                {
                    Name = ld.Location.ToString(),
                    Races = ld.Races?.Select(r => r.ToString()).ToList() ?? new List<string>()
                })
                .OrderBy(x => x.Name)
                .ToList();

            return Ok(items);
        }
    }
}
