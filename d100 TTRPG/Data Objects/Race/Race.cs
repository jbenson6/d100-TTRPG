namespace d100_TTRPG.Data_Objects.Race
{
    public class Race
    {
        public RaceDefinition Definition { get; set; }
        public Race(RaceDefinition definition)
        {
            Definition = definition;
        }
    }
}
