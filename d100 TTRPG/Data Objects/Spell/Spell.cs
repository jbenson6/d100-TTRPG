namespace d100_TTRPG.Data_Objects.Spell
{
    public class Spell
    {
        public SpellDefinition Definition { get; set; }
        public Spell(SpellDefinition definition)
        {
            Definition = definition;
        }
    }
}
