using Microsoft.AspNetCore.Mvc;
using d100_TTRPG.Data_Objects.Talent;

namespace d100_TTRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TalentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var fields = typeof(TalentDb).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            var items = fields
                .Select(f => f.GetValue(null))
                .Where(v => v is TalentDefinition)
                .Cast<TalentDefinition>()
                .Select(td => new
                {
                    Name = td.Name,
                    Tier = td.Tier,
                    Combat = td.Combat,
                    Description = td.Description
                })
                .OrderBy(x => x.Name)
                .ToList();

            return Ok(items);
        }
    }
}
