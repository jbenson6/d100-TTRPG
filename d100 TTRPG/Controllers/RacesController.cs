using Microsoft.AspNetCore.Mvc;
using d100_TTRPG.Data_Objects.Race;
using System.Reflection;
using System.Linq;

namespace d100_TTRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RacesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var fields = typeof(RaceDb).GetFields(BindingFlags.Public | BindingFlags.Static);

            var items = fields
                .Where(f => f.FieldType == typeof(RaceDefinition))
                .Select(f => (RaceDefinition)f.GetValue(null)!)
                .Select(rd => new RaceDto
                {
                    Name = rd.Race.ToString(),

                    Wounds = rd.Wounds,

                    MSK = rd.MSK,
                    RSK = rd.RSK,
                    STR = rd.STR,
                    AGI = rd.AGI,
                    CON = rd.CON,
                    INT = rd.INT,
                    PER = rd.PER,
                    WPR = rd.WPR,
                    CHA = rd.CHA,

                    Skills = rd.Skills?
                        .Select(s => s.Definition.Skill.ToString())
                        .ToList() ?? new List<string>(),

                    Talents = rd.Talents?
                        .Select(t => t.Definition.Talent.ToString())
                        .ToList() ?? new List<string>(),

                    Languages = rd.Languages?
                        .Select(l => l.Definition.Language.ToString())
                        .ToList() ?? new List<string>(),

                    Traits = rd.Traits?
                        .Select(t => t.Definition.Trait.ToString())
                        .ToList() ?? new List<string>(),

                    Spells = rd.Spells?
                        .Select(s => s.Definition.Spell.ToString())
                        .ToList() ?? new List<string>(),

                    Features = rd.Features?
                        .Select(f => f.Definition.Feature.ToString())
                        .ToList() ?? new List<string>()
                })
                .OrderBy(x => x.Name)
                .ToList();

            return Ok(items);
        }

        private class RaceDto
        {
            public string? Name { get; set; }

            public int Wounds { get; set; }

            public int MSK { get; set; }
            public int RSK { get; set; }
            public int STR { get; set; }
            public int AGI { get; set; }
            public int CON { get; set; }
            public int INT { get; set; }
            public int PER { get; set; }
            public int WPR { get; set; }
            public int CHA { get; set; }

            public List<string> Skills { get; set; } = new List<string>();
            public List<string> Talents { get; set; } = new List<string>();
            public List<string> Languages { get; set; } = new List<string>();
            public List<string> Traits { get; set; } = new List<string>();
            public List<string> Spells { get; set; } = new List<string>();
            public List<string> Features { get; set; } = new List<string>();
        }
    }
}