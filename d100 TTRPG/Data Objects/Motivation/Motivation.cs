namespace d100_TTRPG.Data_Objects.Motivation
{
    public class Motivation
    {
        public MotivationDefinition Definition { get; set; }

        public Motivation(MotivationDefinition definition)
        {
            Definition = definition;
        }
    }
}