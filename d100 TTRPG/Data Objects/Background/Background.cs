namespace d100_TTRPG.Data_Objects.Background
{
    public class Background
    {
        public BackgroundDefinition Definition { get; set; }
        public Background(BackgroundDefinition definition)
        {
            Definition = definition;
        }
    }
}