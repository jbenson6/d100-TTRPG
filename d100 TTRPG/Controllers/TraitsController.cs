using Microsoft.AspNetCore.Mvc;
using d100_TTRPG.Data_Objects.Trait;

namespace d100_TTRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TraitsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var fields = typeof(TraitDb).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            var items = fields
                .Select(f => f.GetValue(null))
                .Where(v => v is TraitDefinition)
                .Cast<TraitDefinition>()
                .Select(td => new
                {
                    Name = td.Trait.ToString(),
                    Type = td.Type.ToString(),
                    Description = td.Description
                })
                .OrderBy(x => x.Name)
                .ToList();

            return Ok(items);
        }
    }
}
