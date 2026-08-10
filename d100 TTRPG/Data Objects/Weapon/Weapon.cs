namespace d100_TTRPG.Data_Objects.Weapon
{
    public class Weapon
    {
        public WeaponDefinition Definition { get; set; }
        public Weapon(WeaponDefinition definition)
        {
            Definition = definition;
        }
    }
}
