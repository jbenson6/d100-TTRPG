namespace d100_TTRPG.Data_Objects.Trait
{
    public static class TraitDb
    {
        // ============================================================
        // CREATURE TRAITS
        // ============================================================

        public static readonly TraitDefinition Amorphous = new TraitDefinition(
            Enums.Traits.Amorphous,
            TraitType.Creature,
            "An amorphous creature has a malleable form, capable of squeezing its body or expanding it. " +
            "It can change size by 1 step in either direction. Creatures with this trait determine their movement speeds using 1/2 AGI Bonus, rounded up. " +
            "Amorphous creatures are often missing senses, and so rely on the Unnatural Senses trait to perceive their surroundings."
        );

        public static readonly TraitDefinition Amphibious = new TraitDefinition(
            Enums.Traits.Amphibious,
            TraitType.Creature,
            "Breathe both air and water."
        );

        public static readonly TraitDefinition Bestial = new TraitDefinition(
            Enums.Traits.Bestial,
            TraitType.Creature,
            "A creature with this trait is animalistic, tending to behave instinctively rather than rationally. " +
            "No matter how high its Int score is, it is still bestial. " +
            "A creature with this trait never needs to make a Survival Skill Test whilst in its natural habitat. " +
            "Unless starving or desperate, a bestial creature must make a Willpower Test when frightened, startled, or injured. " +
            "On a failed test, the creature flees."
        );

        public static readonly TraitDefinition Blind = new TraitDefinition(
            Enums.Traits.Blind,
            TraitType.Creature,
            "Blind creatures automatically fail all tests based on vision and automatically fail all RSK Tests. " +
            "Such creatures take a -30 penalty to MSK Tests and most other tests that ordinarily involve or are benefited by vision. " +
            "This Trait indicates not only that the creature cannot see but that it also has no other senses which would provide the same benefit as eyes. " +
            "The Blind Fighting Talent reduces the penalties to MSK Tests as normal for Blind creatures, reducing it from -30 to -15."
        );

        public static readonly TraitDefinition BrutalCharge = new TraitDefinition(
            Enums.Traits.BrutalCharge,
            TraitType.Creature,
            "A creature with this trait deals an extra X points of damage per attack when it charges in the same round.",
            true,
            "Additional damage"
        );

        public static readonly TraitDefinition CatsLuck = new TraitDefinition(
            Enums.Traits.CatsLuck,
            TraitType.Creature,
            "Once per session when this creature would make a Dodge or an AGI Test, they may reroll their test and take the better result."
        );

        public static readonly TraitDefinition Climb = new TraitDefinition(
            Enums.Traits.Climb,
            TraitType.Creature,
            "Through magic or natural means this creature can climb surfaces with a speed of X.",
            true,
            "Climb speed"
        );

        public static readonly TraitDefinition Crawler = new TraitDefinition(
            Enums.Traits.Crawler,
            TraitType.Creature,
            "Worms, serpents, and similar creatures crawl and slither rather than walk. " +
            "The base move for a creature with this trait is half their normal movement rate, rounded up, as determined by their AGI Bonus, " +
            "but they do not take penalties for moving over difficult terrain."
        );

        public static readonly TraitDefinition Darkvision = new TraitDefinition(
            Enums.Traits.Darkvision,
            TraitType.Creature,
            "A creature with this trait sees normally even in areas of total darkness, and never takes a penalty for fighting in areas of dim or no lighting."
        );

        public static readonly TraitDefinition DeadlyNaturalWeapons = new TraitDefinition(
            Enums.Traits.DeadlyNaturalWeapons,
            TraitType.Creature,
            "This creature's natural attacks are powerful enough to crush stone or punch through armor. " +
            "The creature gains all the benefits of the Natural Weapons Trait, except that its attacks no longer have the Primitive Special Quality."
        );

        public static readonly TraitDefinition EnergyResistance = new TraitDefinition(
            Enums.Traits.EnergyResistance,
            TraitType.Creature,
            "The creature has a resistance to specific energy types, and takes reduced damage from those sources. " +
            "Any time the creature would be dealt damage by a spell, weapon, or natural cause, such as falling into freezing water or being struck by lightning, they reduce the damage taken by 5.",
            false,
            null,
            new List<string>
            {
            "Acid",
            "Cold",
            "Electricity",
            "Fire"
            }
        );

        public static readonly TraitDefinition Fear = new TraitDefinition(
            Enums.Traits.Fear,
            TraitType.Creature,
            "A creature with this trait has an unnerving presence. " +
            "The fear of it always has an associated rating (1–4) to reflect just how awful the creature is to behold and is indicated by the number in parenthesis (X). " +
            "The higher the Fear Rating, the harder it is for others to resist going insane from the frailties and precarious sanity of a mortal mind. " +
            "It is immune to Fear, Pinning, and magic powers used to cloud, control, or delude its minds.",
            true,
            "Fear Rating (1–4)"
        );

        public static readonly TraitDefinition Flyer = new TraitDefinition(
            Enums.Traits.Flyer,
            TraitType.Creature,
            "A creature with this trait has the natural ability to fly, whether with broad feathery wings, strange magical energies, or inflatable gas sacs. " +
            "The number in parenthesis (X) indicates its speed when flying. This number replaces its AGI Bonus for movement Actions.",
            true,
            "Flying speed"
        );

        public static readonly TraitDefinition Immune = new TraitDefinition(
            Enums.Traits.Immune,
            TraitType.Creature,
            "A creature with this ability is immune to the listed energy or effect, and cannot be damaged or affected by anything of that type, " +
            "such as a specific energy group, Fear effects, or a chosen school of magic.",
            false,
            null,
            new List<string>
            {
            "Energy",
            "Effect",
            "Fear",
            "Magic School"
            }
        );

        public static readonly TraitDefinition Incorporeal = new TraitDefinition(
            Enums.Traits.Incorporeal,
            TraitType.Creature,
            "Incorporeal creatures are insubstantial and weightless, able to pass through solid objects such as walls and weapons. " +
            "An incorporeal creature gains a +30 bonus on Stealth Tests due to their ability to merge with objects and the fact they make practically no sounds when they move. " +
            "Incorporeal creatures gain the Hoverer (6) trait. " +
            "An incorporeal creature is also immune to normal weapons—they simply pass through its body as if it wasn't there. " +
            "Spells, other incorporeal creatures, and opponents armed with magical weapons may all injure an incorporeal creature normally. " +
            "An incorporeal creature can't normally affect the mortal world, and thus can't Damage non-incorporeal opponents unless it has a suitable special ability or Talent. " +
            "Creatures with the Incorporeal trait can Damage other creatures with the Incorporeal trait normally."
        );

        public static readonly TraitDefinition Legs = new TraitDefinition(
            Enums.Traits.Legs,
            TraitType.Creature,
            "You have more than two legs. For every pair of legs you have beyond 2, increase your base movement speed by 1, up to +3 total from this trait.",
            true,
            "Number of legs beyond 2"
        );

        public static readonly TraitDefinition MonstrousFeature = new TraitDefinition(
            Enums.Traits.MonstrousFeature,
            TraitType.Creature,
            "The character has one or more of the following: claws, fangs, horns, tails, wings, etc. " +
            "These may grant them Natural Attacks or a special movement speed."
        );

        public static readonly TraitDefinition NaturalArmor = new TraitDefinition(
            Enums.Traits.NaturalArmor,
            TraitType.Creature,
            "This creature has natural armor points equal to X.",
            true,
            "Natural armor points"
        );

        public static readonly TraitDefinition PrehensileTail = new TraitDefinition(
            Enums.Traits.PrehensileTail,
            TraitType.Creature,
            "A controllable tail with the ability to dexterously manipulate objects, such as retrieving an item from a pouch, wrapping around a branch, or gently tapping another on their shoulder, and so on. " +
            "Cannot be used to wield a weapon or operate equipment."
        );

        public static readonly TraitDefinition Regenerate = new TraitDefinition(
            Enums.Traits.Regenerate,
            TraitType.Creature,
            "A creature with this trait recovers wounds equal to its CON Bonus at the beginning of its turn, can repair lost limbs if re-attached or grow new ones. " +
            "For some creatures, this ability is negated when it takes certain types of damage, such as acid or fire."
        );

        public static readonly TraitDefinition Swim = new TraitDefinition(
            Enums.Traits.Swim,
            TraitType.Creature,
            "Through magical or natural means this creature can move in water at a speed of X.",
            true,
            "Swim speed"
        );

        public static readonly TraitDefinition Truesight = new TraitDefinition(
            Enums.Traits.Truesight,
            TraitType.Creature,
            "Immune to illusions."
        );

        public static readonly TraitDefinition Unliving = new TraitDefinition(
            Enums.Traits.Unliving,
            TraitType.Creature,
            "This creature is not alive. It does not need to eat, breathe, or rest, does not gain LoF, and does not heal naturally."
        );

        public static readonly TraitDefinition Vulnerability = new TraitDefinition(
            Enums.Traits.Vulnerability,
            TraitType.Creature,
            "The creature is weak to certain energies and types of damage, and takes 1.5x the damage from attacks of that type.",
            false,
            null,
            new List<string>
            {
            "Bashing",
            "Piercing",
            "Slashing",
            "Acid",
            "Cold",
            "Electricity",
            "Fire"
            }
        );


        // ============================================================
        // WEAPON TRAITS
        // ============================================================

        public static readonly TraitDefinition Balanced = new TraitDefinition(
            Enums.Traits.Balanced,
            TraitType.Weapon,
            "+10 on Parry Tests."
        );

        public static readonly TraitDefinition Blast = new TraitDefinition(
            Enums.Traits.Blast,
            TraitType.Weapon,
            null
        );

        public static readonly TraitDefinition Cover = new TraitDefinition(
            Enums.Traits.Cover,
            TraitType.Weapon,
            "You may use the Take Cover combat action with this piece of equipment, with an effective AP of X.",
            true,
            "Effective AP"
        );

        public static readonly TraitDefinition Defensive = new TraitDefinition(
            Enums.Traits.Defensive,
            TraitType.Weapon,
            "Gain a +20 on Parry Test with this weapon, and allows the character to Parry ranged projectiles up to 3 sizes smaller than them."
        );

        public static readonly TraitDefinition Pounce = new TraitDefinition(
            Enums.Traits.Pounce,
            TraitType.Weapon,
            "When attacking with a weapon with this trait, you may leap X yd forwards as part of your attack as a free action if it is your first attack this round. " +
            "X is equal to the wielder's AGI Bonus.",
            true,
            "AGI Bonus"
        );

        public static readonly TraitDefinition Primitive = new TraitDefinition(
            Enums.Traits.Primitive,
            TraitType.Weapon,
            "Damage rolls higher than X are rounded down to X.",
            true,
            "Maximum damage"
        );

        public static readonly TraitDefinition Proven = new TraitDefinition(
            Enums.Traits.Proven,
            TraitType.Weapon,
            "Rolls lower than X are rounded up to X.",
            true,
            "Minimum roll"
        );

        public static readonly TraitDefinition Unbalanced = new TraitDefinition(
            Enums.Traits.Unbalanced,
            TraitType.Weapon,
            "-10 on Parry Tests."
        );

        public static readonly TraitDefinition Unwieldy = new TraitDefinition(
            Enums.Traits.Unwieldy,
            TraitType.Weapon,
            "Cannot Parry with this weapon."
        );

        public static readonly TraitDefinition Snare = new TraitDefinition(
            Enums.Traits.Snare,
            TraitType.Weapon,
            "A target hit by a weapon with this trait gains the Entangled condition, and must pass a Challenging [+0] STR or Escape with a -10 times X penalty.",
            true,
            "Escape penalty multiplier"
        );

        public static readonly TraitDefinition Toxic = new TraitDefinition(
            Enums.Traits.Toxic,
            TraitType.Weapon,
            "Whenever a creature is damaged by this weapon, they must pass a Challenging [+0] Con Test with difficulty increased by X steps. " +
            "If they fail, they take 1d10 + X Toxic damage (minimum +1).",
            true,
            "Difficulty steps / Toxic damage"
        );

        public static readonly TraitDefinition Tail = new TraitDefinition(
            Enums.Traits.Tail,
            TraitType.Creature,
            "Tail",
            false,
            ""
        );

        public static readonly TraitDefinition Sleepless = new TraitDefinition(
            Enums.Traits.Sleepless,
            TraitType.Creature,
            "Sleepless",
            false,
            ""
        );

        public static readonly TraitDefinition Scent = new TraitDefinition(
            Enums.Traits.Scent,
           TraitType.Creature,
            "Scent",
            false,
            ""
        );

        public static readonly TraitDefinition Flight = new TraitDefinition(
            Enums.Traits.Flight,
            TraitType.Creature,
            "Flight",
            false,
            ""
        );

        public static readonly TraitDefinition Wings = new TraitDefinition(
            Enums.Traits.Wings,
            TraitType.Creature,
            "Wings",
            false,
            ""
        );

        public static readonly TraitDefinition Horns = new TraitDefinition(
            Enums.Traits.Horns,
            TraitType.Creature,
            "Horns",
            false,
            ""
        );

        public static readonly TraitDefinition HybridForm = new TraitDefinition(
            Enums.Traits.HybridForm,
            TraitType.Creature,
            "HybridForm",
            false,
            ""
        );


    }
}
