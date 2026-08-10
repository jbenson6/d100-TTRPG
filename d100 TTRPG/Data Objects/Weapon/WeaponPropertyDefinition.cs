using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.Weapon
{
    public class WeaponPropertyDefinition
    {
        public WeaponProperty Property { get; set; }

        public string? Description { get; set; }

        public WeaponPropertyDefinition(
            WeaponProperty property,
            string? description = null)
        {
            Property = property;
            Description = description;
        }
    }
}
