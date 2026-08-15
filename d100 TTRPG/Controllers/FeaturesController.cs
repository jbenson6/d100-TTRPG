using Microsoft.AspNetCore.Mvc;
using d100_TTRPG.Data_Objects.Feature;
using System.Reflection;
using System.Linq;

namespace d100_TTRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeaturesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var fields = typeof(FeatureDb).GetFields(BindingFlags.Public | BindingFlags.Static);
            var items = fields
                .Where(f => f.FieldType == typeof(FeatureDefinition))
                .Select(f => (FeatureDefinition)f.GetValue(null)!)
                .Select(fd => new FeatureDto
                {
                    Name = fd.Feature.ToString(),
                    MP = fd.MP,
                    Wounds = fd.Wounds,
                    Armor = fd.ArmorProficiency.ToString(),
                    Description = fd.Description,
                    CharBonuses = fd.CharBonus?.Select(c => c.ToString()).ToList() ?? new List<string>(),
                    PreReqChar = fd.PreReqChar?.ToDictionary(kv => kv.Key.ToString(), kv => kv.Value) ?? new Dictionary<string,int>(),
                    Skills = fd.Skills?.Select(s => s.Definition.Skill.ToString()).ToList() ?? new List<string>(),
                    Talents = fd.Talents?.Select(t => t.Definition.Talent.ToString()).ToList() ?? new List<string>(),
                    Traits = fd.Traits?.Select(t => t.Definition.Trait.ToString()).ToList() ?? new List<string>(),
                })
                .OrderBy(x => x.Name)
                .ToList();

            return Ok(items);
        }

        private class FeatureDto
        {
            public string? Name { get; set; }
            public int MP { get; set; }
            public int Wounds { get; set; }
            public string? Armor { get; set; }
            public string? Description { get; set; }
            public List<string> CharBonuses { get; set; } = new List<string>();
            public Dictionary<string,int> PreReqChar { get; set; } = new Dictionary<string,int>();
            public List<string> Skills { get; set; } = new List<string>();
            public List<string> Talents { get; set; } = new List<string>();
            public List<string> Traits { get; set; } = new List<string>();
        }
    }
}
