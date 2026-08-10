namespace d100_TTRPG.Data_Objects.Language
{
    public class Language
    {
        public LanguageDefinition Definition { get; set; }
        public Language(LanguageDefinition definition)
        {  
            Definition = definition; 
        }
    }
}
