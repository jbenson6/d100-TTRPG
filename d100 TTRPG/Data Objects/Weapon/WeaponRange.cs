namespace d100_TTRPG.Data_Objects.Weapon
{
    public enum RangeType
    {
        Melee = 1,
        Strength = 2,
        RangedSkill = 3,
        Fixed = 4
    }

    public class WeaponRange
    {
        public RangeType Type { get; set; }
        public int Value { get; set; }
        public int? Maximum { get; set; }

        public WeaponRange(
            RangeType type,
            int value = 0,
            int? maximum = null)
        {
            Type = type;
            Value = value;
            Maximum = maximum;
        }
    }
}
