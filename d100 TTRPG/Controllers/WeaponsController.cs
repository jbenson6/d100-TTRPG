using Microsoft.AspNetCore.Mvc;
using d100_TTRPG.Data_Objects.Weapon;

namespace d100_TTRPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeaponsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var fields = typeof(WeaponDb).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            var items = fields
                .Select(f => f.GetValue(null))
                .OfType<WeaponDefinition>()
                .Select(w => new
                {
                    Name = w.Name,
                    Hands = w.Hands.ToString(),
                    Range = GetRangeString(w.Range),
                    Damage = w.Damage != null ? $"{w.Damage.DiceCount}d{w.Damage.DiceSides}{(w.Damage.Modifier != 0 ? (w.Damage.Modifier > 0 ? "+" + w.Damage.Modifier : w.Damage.Modifier.ToString()) : "")}" : null,
                    Penetration = w.Penetration,
                    DamageTypes = w.DamageTypes != null ? string.Join(",", w.DamageTypes) : null,
                    Traits = w.Traits != null ? string.Join(",", w.Traits.Select(t => t.Definition?.Trait.ToString() ?? t.ToString())) : null
                })
                .OrderBy(x => x.Name)
                .ToList();

        static string GetRangeString(WeaponRange? r)
        {
            if (r == null) return "";
            return r.Type switch
            {
                RangeType.Melee => "Melee",
                RangeType.Strength => $"Strength {r.Value}",
                RangeType.RangedSkill => $"RangedSkill {r.Value}",
                RangeType.Fixed => r.Maximum.HasValue ? $"{r.Value}-{r.Maximum} yd" : $"{r.Value} yd",
                _ => r.ToString() ?? ""
            };
        }

            return Ok(items);
        }
    }
}
