

namespace d100_TTRPG.Data_Objects.Armor
{
    public class ArmorDefinition
    {
        public Enums.Armor ArmorType { get; set; }
        public int SpeedModifier { get; set; }
        public int TestPenalty { get; set; }
        public int ArmorPoints { get; set; }

        public ArmorDefinition(Enums.Armor armorType, int speedModifier, int testPenalty, int armorPoints)
        {
            ArmorType = armorType;
            SpeedModifier = speedModifier;
            TestPenalty = testPenalty;
            ArmorPoints = armorPoints;
        }
    }
}