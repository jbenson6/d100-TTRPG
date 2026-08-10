using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.Weapon
{
    public class WeaponDefinition
    {
        public string Name { get; set; }

        public WeaponHands Hands { get; set; }

        public WeaponRange Range { get; set; }

        public DamageDefinition? Damage { get; set; }

        public int Penetration { get; set; }

        public List<DamageType> DamageTypes { get; set; }

        public List<Trait.Trait> Traits { get; set; }

        public List<WeaponPropertyDefinition> Properties { get; set; }

        public WeaponDefinition(
            string name,
            WeaponHands hands,
            WeaponRange range,
            DamageDefinition? damage,
            int penetration,
            List<DamageType> damageTypes,
            List<Trait.Trait>? traits = null,
            List<WeaponPropertyDefinition>? properties = null)
        {
            Name = name;
            Hands = hands;
            Range = range;
            Damage = damage;
            Penetration = penetration;
            DamageTypes = damageTypes;
            Traits = traits ?? new List<Trait.Trait>();
            Properties = properties ?? new List<WeaponPropertyDefinition>();
        }
    }
}
