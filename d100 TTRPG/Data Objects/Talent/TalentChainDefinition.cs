using d100_TTRPG.Enums;
using System.Collections.Generic;

namespace d100_TTRPG.Data_Objects.Talent
{
    public class TalentChainDefinition
    {
        public TalentChains Talent { get; set; }

        public string Name { get; set; }

        public int Tier { get; set; }

        public bool Combat { get; set; }

        public List<TalentPrerequisite> Prerequisites { get; set; }

        public string Description { get; set; }

        public bool Repeatable { get; set; }

        public int? MaximumRanks { get; set; }

        public TalentChainDefinition(
            TalentChains talent,
            string name,
            int tier,
            bool combat,
            string description,
            List<TalentPrerequisite>? prerequisites = null,
            bool repeatable = false,
            int? maximumRanks = null)
        {
            Talent = talent;
            Name = name;
            Tier = tier;
            Combat = combat;
            Description = description;
            Prerequisites = prerequisites ?? new List<TalentPrerequisite>();
            Repeatable = repeatable;
            MaximumRanks = maximumRanks;
        }
    }
}