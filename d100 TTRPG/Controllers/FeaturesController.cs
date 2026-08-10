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
                    Description = fd.Description
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
        }
    }
}
