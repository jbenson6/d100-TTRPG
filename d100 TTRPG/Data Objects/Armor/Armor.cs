namespace d100_TTRPG.Data_Objects.Armor
{
    public class Armor
    {
        public ArmorDefinition Definition { get; }
        public Armor(ArmorDefinition armorDefinition) 
        {
            Definition = armorDefinition;
        }
    }
}
