using Microsoft.AspNetCore.Mvc;
using d100_TTRPG.Data_Objects.Trade;

namespace d100_TTRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TradesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var fields = typeof(TradeDb).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            var items = fields
                .Select(f => f.GetValue(null))
                .Where(v => v != null)
                .OfType<TradeDefinition>()
                .Select(td => new
                {
                    Name = td.Trade.ToString(),
                    Description = td.Description,
                    Talent = td.Talent?.Definition?.Name ?? td.Talent?.Definition?.Talent.ToString(),
                    Skills = td.Skills?.Select(s => s.ToString()).ToList() ?? new List<string>()
                })
                .OrderBy(x => x.Name)
                .ToList();

            return Ok(items);
        }
    }
}
