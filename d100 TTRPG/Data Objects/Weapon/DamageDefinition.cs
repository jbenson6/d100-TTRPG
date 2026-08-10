namespace d100_TTRPG.Data_Objects.Weapon
{
    public class DamageDefinition
    {
        public int DiceCount { get; set; }
        public int DiceSides { get; set; }
        public int Modifier { get; set; }

        public DamageDefinition(int diceCount, int diceSides, int modifier = 0)
        {
            DiceCount = diceCount;
            DiceSides = diceSides;
            Modifier = modifier;
        }
    }
}
