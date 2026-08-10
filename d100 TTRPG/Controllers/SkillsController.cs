using Microsoft.AspNetCore.Mvc;
using d100_TTRPG.Data_Objects.Skill;

namespace d100_TTRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SkillsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var fields = typeof(SkillDb).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            var items = fields
                .Select(f => f.GetValue(null))
                .Where(v => v is SkillDefinition)
                .Cast<SkillDefinition>()
                .Select(sd => new
                {
                    Name = sd.Skill.ToString(),
                    Description = sd.Description
                })
                .OrderBy(x => x.Name)
                .ToList();

            return Ok(items);
        }
    }
}
