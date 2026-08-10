using Microsoft.AspNetCore.Mvc;
using d100_TTRPG.Data_Objects.Background;

namespace d100_TTRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BackgroundsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var fields = typeof(BackgroundDb).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            var items = fields
                .Select(f => f.GetValue(null))
                .Where(v => v is BackgroundDefinition)
                .Cast<BackgroundDefinition>()
                .Select(bd => new
                {
                    Name = bd.Background.ToString(),
                    Description = bd.Description,
                    AdditionalNotes = bd.AdditionalNotes
                })
                .OrderBy(x => x.Name)
                .ToList();

            return Ok(items);
        }
    }
}
