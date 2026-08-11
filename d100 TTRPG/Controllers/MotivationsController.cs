using Microsoft.AspNetCore.Mvc;
using d100_TTRPG.Data_Objects.Motivation;

namespace d100_TTRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MotivationsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var fields = typeof(MotivationDb).GetFields(
                System.Reflection.BindingFlags.Public |
                System.Reflection.BindingFlags.Static);

            var items = fields
                .Select(f => f.GetValue(null))
                .Where(v => v != null)
                .OfType<MotivationDefinition>()
                .Select(md => new
                {
                    Name = md.Motivation.ToString(),
                    Description = md.Description,

                    // Return the motivation skills so the Blazor UI
                    // can add them to skillCounts.
                    Skills = md.Skills?
                        .Select(s => s.ToString())
                        .ToList(),

                    Talent = md.Talent?.ToString(),

                    AdditionalNotes = md.AdditionalNotes
                })
                .OrderBy(x => x.Name)
                .ToList();

            return Ok(items);
        }
    }
}
