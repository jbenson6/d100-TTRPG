using Microsoft.AspNetCore.Mvc;
using d100_TTRPG.Data_Objects.Weapon;

namespace d100_TTRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeaponsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var fields = typeof(WeaponDb).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            var items = fields
                .Select(f => f.GetValue(null))
                .Where(v => v != null)
                .Select(v => new {
                    Name = v.GetType().GetProperty("Weapon")?.GetValue(v)?.ToString() ?? v.ToString(),
                    Description = v.GetType().GetProperty("Description")?.GetValue(v)?.ToString()
                })
                .OrderBy(x => x.Name)
                .ToList();

            return Ok(items);
        }
    }
}
