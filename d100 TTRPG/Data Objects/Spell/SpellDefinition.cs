using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.Spell
{
    public class SpellDefinition
    {
        public Enums.Spells Spell { get; set; }
        public MagicSchools MagicSchool { get; set; }
        public int XpCost { get; set; }
        public Characteristics TestChar {  get; set; }
        public int MPReq {  get; set; }
        public int INTReq { get; set; }
        public int Range { get; set; }
        public int NumTargets { get; set; }
        public CastingTimes CastingTime { get; set; }
        public int CastDifficulty { get; set; }

        public SpellDefinition() { }
    }
}
