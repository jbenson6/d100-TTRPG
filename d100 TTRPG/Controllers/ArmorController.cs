using Microsoft.AspNetCore.Mvc;
using d100_TTRPG.Data_Objects.Armor;

namespace d100_TTRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArmorController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var fields = typeof(ArmorDb).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            var items = fields
                .Select(f => f.GetValue(null))
                .Where(v => v != null)
                .Select(v => new
                {
                    Name = v.GetType().GetProperty("ArmorType")?.GetValue(v)?.ToString() ?? v.ToString(),
                    ArmorPoints = v.GetType().GetProperty("ArmorPoints")?.GetValue(v)
                })
                .OrderBy(x => x.ArmorPoints)
                .ToList();

            return Ok(items);
        }
    }
}
