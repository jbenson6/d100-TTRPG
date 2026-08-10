namespace d100_TTRPG.Data_Objects.Language
{
    public class LanguageDefinition
    {
        public Enums.Languages Language { get; set; }
        public string? Description { get; set; }

        public LanguageDefinition(Enums.Languages language, string description)
        {
            Language = language;
            Description = description;
        }
    }
}
