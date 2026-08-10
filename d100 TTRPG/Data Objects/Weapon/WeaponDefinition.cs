using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.Weapon
{
    public class WeaponDefinition
    {
        public string Name { get; set; }
        public int Penetration { get; set; }
        public int Hand { get; set; }
        public int Range { get; set; }
        public List<DamageType>? DamageTypes { get; set; }
        public List<Trait.Trait>? Traits { get; set; }
        public WeaponDefinition(string name, int penetration, int hand, int range, List<DamageType> damageTypes, List<Trait> traits) 
        {
            Name = name;
            Penetration = penetration;
            Hand = hand;
            Range = range;
            DamageTypes = damageTypes;
            Traits = traits;
        }
    }
}
