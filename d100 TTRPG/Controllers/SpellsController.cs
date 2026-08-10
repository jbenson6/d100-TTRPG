using Microsoft.AspNetCore.Mvc;
using d100_TTRPG.Data_Objects.Spell;

namespace d100_TTRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpellsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // SpellDb exposes a Dictionary<Enums.Spells, SpellDefinition>
            var field = typeof(SpellDb).GetField("Spells", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            var dict = field?.GetValue(null) as System.Collections.IDictionary;
            var items = new List<object>();

            if (dict != null)
            {
                foreach (System.Collections.DictionaryEntry entry in dict)
                {
                    var key = entry.Key?.ToString() ?? "";
                    var sd = entry.Value as SpellDefinition;
                    if (sd != null)
                    {
                        items.Add(new
                        {
                            Name = key,
                            MP = sd.MPReq,
                            CastDifficulty = sd.CastDifficulty,
                            MagicSchool = sd.MagicSchool.ToString(),
                            Range = sd.Range,
                            NumTargets = sd.NumTargets
                        });
                    }
                }
            }

            return Ok(items.OrderBy(x => ((dynamic)x).Name).ToList());
        }
    }
}
