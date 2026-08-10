using Microsoft.AspNetCore.Mvc;
using d100_TTRPG.Data_Objects.Race;

namespace d100_TTRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RacesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var fields = typeof(RaceDb).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            var items = fields
                .Select(f => f.GetValue(null))
                .Where(v => v != null)
                .OfType<d100_TTRPG.Data_Objects.Race.RaceDefinition>()
                .Select(r => new {
                    Name = r.Race.ToString(),
                    Wounds = r.Wounds,
                    MSK = r.MSK,
                    RSK = r.RSK,
                    STR = r.STR,
                    AGI = r.AGI,
                    CON = r.CON,
                    INT = r.INT,
                    PER = r.PER,
                    WPR = r.WPR,
                    CHA = r.CHA
                })
                .OrderBy(x => x.Name)
                .ToList();

            return Ok(items);
        }
    }
}
