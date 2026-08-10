namespace d100_TTRPG.Data_Objects.Talent
{
    public class Talent
    {
        public TalentDefinition Definition { get; set; }
        public Talent(TalentDefinition definition)
        {
            Definition = definition;
        }
    }
}
