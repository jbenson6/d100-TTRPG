using System.Collections.Generic;
using d100_TTRPG.Enums;

namespace d100_TTRPG.Data_Objects.Spell
{
    public static class SpellDb
    {
        public static readonly Dictionary<Enums.Spells, SpellDefinition> Spells =
        new Dictionary<Enums.Spells, SpellDefinition>
        {
            // ============================================================
            // ABJURATION
            // ============================================================

            [Enums.Spells.Dispel] = new SpellDefinition
            {
                Spell = Enums.Spells.Dispel,
                MagicSchool = MagicSchools.Abjuration,
                XpCost = 0,
                TestChar = Characteristics.INT,
                MPReq = 4,
                INTReq = 0,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = -10
            },

            [Enums.Spells.ElementalResistance] = new SpellDefinition
            {
                Spell = Enums.Spells.ElementalResistance,
                MagicSchool = MagicSchools.Abjuration,
                XpCost = 250,
                TestChar = Characteristics.INT,
                MPReq = 1,
                INTReq = 35,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 30
            },

            [Enums.Spells.GlyphOfWarding] = new SpellDefinition
            {
                Spell = Enums.Spells.GlyphOfWarding,
                MagicSchool = MagicSchools.Abjuration,
                XpCost = 300,
                TestChar = Characteristics.INT,
                MPReq = 3,
                INTReq = 30,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 0
            },

            [Enums.Spells.Shield] = new SpellDefinition
            {
                Spell = Enums.Spells.Shield,
                MagicSchool = MagicSchools.Abjuration,
                XpCost = 150,
                TestChar = Characteristics.INT,
                MPReq = 2,
                INTReq = 35,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.Reaction,
                CastDifficulty = 30
            },

            [Enums.Spells.Seal] = new SpellDefinition
            {
                Spell = Enums.Spells.Seal,
                MagicSchool = MagicSchools.Abjuration,
                XpCost = 400,
                TestChar = Characteristics.INT,
                MPReq = 6,
                INTReq = 40,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.FullAction,
                CastDifficulty = -20
            },

            // ============================================================
            // CONJURATION
            // ============================================================

            [Enums.Spells.AnimateWeapon] = new SpellDefinition
            {
                Spell = Enums.Spells.AnimateWeapon,
                MagicSchool = MagicSchools.Conjuration,
                XpCost = 300,
                TestChar = Characteristics.INT,
                MPReq = 2,
                INTReq = 35,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.SwiftAction,
                CastDifficulty = 30
            },

            [Enums.Spells.ArcaneBind] = new SpellDefinition
            {
                Spell = Enums.Spells.ArcaneBind,
                MagicSchool = MagicSchools.Conjuration,
                XpCost = 100,
                TestChar = Characteristics.INT,
                MPReq = 2,
                INTReq = 40,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 10
            },

            [Enums.Spells.ArcaneGate] = new SpellDefinition
            {
                Spell = Enums.Spells.ArcaneGate,
                MagicSchool = MagicSchools.Conjuration,
                XpCost = 500,
                TestChar = Characteristics.INT,
                MPReq = 5,
                INTReq = 45,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.FullAction,
                CastDifficulty = 0
            },

            [Enums.Spells.MistyStep] = new SpellDefinition
            {
                Spell = Enums.Spells.MistyStep,
                MagicSchool = MagicSchools.Conjuration,
                XpCost = 200,
                TestChar = Characteristics.INT,
                MPReq = 3,
                INTReq = 30,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.SwiftAction,
                CastDifficulty = -10
            },

            [Enums.Spells.CreateWater] = new SpellDefinition
            {
                Spell = Enums.Spells.CreateWater,
                MagicSchool = MagicSchools.Conjuration,
                XpCost = 100,
                TestChar = Characteristics.INT,
                MPReq = 1,
                INTReq = 0,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 0
            },

            [Enums.Spells.EtherealChest] = new SpellDefinition
            {
                Spell = Enums.Spells.EtherealChest,
                MagicSchool = MagicSchools.Conjuration,
                XpCost = 250,
                TestChar = Characteristics.INT,
                MPReq = 2,
                INTReq = 35,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 0
            },

            [Enums.Spells.Grease] = new SpellDefinition
            {
                Spell = Enums.Spells.Grease,
                MagicSchool = MagicSchools.Conjuration,
                XpCost = 100,
                TestChar = Characteristics.INT,
                MPReq = 1,
                INTReq = 30,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 10
            },

            [Enums.Spells.Light] = new SpellDefinition
            {
                Spell = Enums.Spells.Light,
                MagicSchool = MagicSchools.Conjuration,
                XpCost = 0,
                TestChar = Characteristics.INT,
                MPReq = 1,
                INTReq = 0,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 0
            },

            [Enums.Spells.MageHand] = new SpellDefinition
            {
                Spell = Enums.Spells.MageHand,
                MagicSchool = MagicSchools.Conjuration,
                XpCost = 0,
                TestChar = Characteristics.INT,
                MPReq = 1,
                INTReq = 0,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 30
            },

            [Enums.Spells.PungentOdor] = new SpellDefinition
            {
                Spell = Enums.Spells.PungentOdor,
                MagicSchool = MagicSchools.Conjuration,
                XpCost = 250,
                TestChar = Characteristics.INT,
                MPReq = 1,
                INTReq = 35,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.FullAction,
                CastDifficulty = 0
            },

            [Enums.Spells.RuinousFog] = new SpellDefinition
            {
                Spell = Enums.Spells.RuinousFog,
                MagicSchool = MagicSchools.Conjuration,
                XpCost = 250,
                TestChar = Characteristics.INT,
                MPReq = 3,
                INTReq = 35,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 10
            },

            [Enums.Spells.SummonArmor] = new SpellDefinition
            {
                Spell = Enums.Spells.SummonArmor,
                MagicSchool = MagicSchools.Conjuration,
                XpCost = 100,
                TestChar = Characteristics.INT,
                MPReq = 2,
                INTReq = 30,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 30
            },

            // ============================================================
            // DIVINATION
            // ============================================================

            [Enums.Spells.Fateseal] = new SpellDefinition
            {
                Spell = Enums.Spells.Fateseal,
                MagicSchool = MagicSchools.Divination,
                XpCost = 300,
                TestChar = Characteristics.INT,
                MPReq = 4,
                INTReq = 40,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 0
            },

            [Enums.Spells.Track] = new SpellDefinition
            {
                Spell = Enums.Spells.Track,
                MagicSchool = MagicSchools.Divination,
                XpCost = 150,
                TestChar = Characteristics.PER,
                MPReq = 1,
                INTReq = 0,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.FullAction,
                CastDifficulty = 0
            },

            [Enums.Spells.MemoryDelve] = new SpellDefinition
            {
                Spell = Enums.Spells.MemoryDelve,
                MagicSchool = MagicSchools.Divination,
                XpCost = 200,
                TestChar = Characteristics.INT,
                MPReq = 5,
                INTReq = 40,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.FullAction,
                CastDifficulty = -20
            },

            // ============================================================
            // ENCHANTMENT
            // ============================================================

            [Enums.Spells.CharmPerson] = new SpellDefinition
            {
                Spell = Enums.Spells.CharmPerson,
                MagicSchool = MagicSchools.Enchantment,
                XpCost = 200,
                TestChar = Characteristics.INT,
                MPReq = 2,
                INTReq = 30,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.FullAction,
                CastDifficulty = 20
            },

            [Enums.Spells.Despair] = new SpellDefinition
            {
                Spell = Enums.Spells.Despair,
                MagicSchool = MagicSchools.Enchantment,
                XpCost = 250,
                TestChar = Characteristics.INT,
                MPReq = 3,
                INTReq = 35,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 0
            },

            [Enums.Spells.Goad] = new SpellDefinition
            {
                Spell = Enums.Spells.Goad,
                MagicSchool = MagicSchools.Enchantment,
                XpCost = 250,
                TestChar = Characteristics.INT,
                MPReq = 1,
                INTReq = 30,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 20
            },

            [Enums.Spells.InstillFear] = new SpellDefinition
            {
                Spell = Enums.Spells.InstillFear,
                MagicSchool = MagicSchools.Enchantment,
                XpCost = 200,
                TestChar = Characteristics.INT,
                MPReq = 1,
                INTReq = 35,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 20
            },

            [Enums.Spells.Obliviate] = new SpellDefinition
            {
                Spell = Enums.Spells.Obliviate,
                MagicSchool = MagicSchools.Enchantment,
                XpCost = 250,
                TestChar = Characteristics.INT,
                MPReq = 3,
                INTReq = 40,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.FullAction,
                CastDifficulty = 0
            },

            [Enums.Spells.Stupor] = new SpellDefinition
            {
                Spell = Enums.Spells.Stupor,
                MagicSchool = MagicSchools.Enchantment,
                XpCost = 150,
                TestChar = Characteristics.INT,
                MPReq = 1,
                INTReq = 35,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 10
            },

            [Enums.Spells.TurnFoe] = new SpellDefinition
            {
                Spell = Enums.Spells.TurnFoe,
                MagicSchool = MagicSchools.Enchantment,
                XpCost = 300,
                TestChar = Characteristics.INT,
                MPReq = 3,
                INTReq = 0,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 0
            },

            // ============================================================
            // EVOCATION
            // ============================================================

            [Enums.Spells.CallLightning] = new SpellDefinition
            {
                Spell = Enums.Spells.CallLightning,
                MagicSchool = MagicSchools.Evocation,
                XpCost = 200,
                TestChar = Characteristics.INT,
                MPReq = 2,
                INTReq = 35,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.FullAction,
                CastDifficulty = 0
            },

            [Enums.Spells.ElementalBarrier] = new SpellDefinition
            {
                Spell = Enums.Spells.ElementalBarrier,
                MagicSchool = MagicSchools.Evocation,
                XpCost = 350,
                TestChar = Characteristics.INT,
                MPReq = 3,
                INTReq = 40,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.Reaction,
                CastDifficulty = 30
            },

            [Enums.Spells.ElementalBlast] = new SpellDefinition
            {
                Spell = Enums.Spells.ElementalBlast,
                MagicSchool = MagicSchools.Evocation,
                XpCost = 300,
                TestChar = Characteristics.INT,
                MPReq = 2,
                INTReq = 35,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 10
            },

            [Enums.Spells.ElementalSphere] = new SpellDefinition
            {
                Spell = Enums.Spells.ElementalSphere,
                MagicSchool = MagicSchools.Evocation,
                XpCost = 300,
                TestChar = Characteristics.INT,
                MPReq = 2,
                INTReq = 30,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.FullAction,
                CastDifficulty = 10
            },

            [Enums.Spells.FeyFire] = new SpellDefinition
            {
                Spell = Enums.Spells.FeyFire,
                MagicSchool = MagicSchools.Evocation,
                XpCost = 100,
                TestChar = Characteristics.INT,
                MPReq = 1,
                INTReq = 30,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.SwiftAction,
                CastDifficulty = 20
            },

            [Enums.Spells.Immolation] = new SpellDefinition
            {
                Spell = Enums.Spells.Immolation,
                MagicSchool = MagicSchools.Evocation,
                XpCost = 300,
                TestChar = Characteristics.INT,
                MPReq = 4,
                INTReq = 40,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.FullAction,
                CastDifficulty = 10
            },

            [Enums.Spells.KineticBombardment] = new SpellDefinition
            {
                Spell = Enums.Spells.KineticBombardment,
                MagicSchool = MagicSchools.Evocation,
                XpCost = 500,
                TestChar = Characteristics.INT,
                MPReq = 5,
                INTReq = 40,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.FullAction,
                CastDifficulty = -10
            },

            [Enums.Spells.SonicBoom] = new SpellDefinition
            {
                Spell = Enums.Spells.SonicBoom,
                MagicSchool = MagicSchools.Evocation,
                XpCost = 200,
                TestChar = Characteristics.INT,
                MPReq = 3,
                INTReq = 35,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 0
            },

            [Enums.Spells.Radiance] = new SpellDefinition
            {
                Spell = Enums.Spells.Radiance,
                MagicSchool = MagicSchools.Evocation,
                XpCost = 200,
                TestChar = Characteristics.INT,
                MPReq = 2,
                INTReq = 30,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 10
            },

            // ============================================================
            // ILLUSION
            // ============================================================

            [Enums.Spells.DoubleImage] = new SpellDefinition
            {
                Spell = Enums.Spells.DoubleImage,
                MagicSchool = MagicSchools.Illusion,
                XpCost = 250,
                TestChar = Characteristics.INT,
                MPReq = 3,
                INTReq = 35,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 0
            },

            [Enums.Spells.Invisibility] = new SpellDefinition
            {
                Spell = Enums.Spells.Invisibility,
                MagicSchool = MagicSchools.Illusion,
                XpCost = 250,
                TestChar = Characteristics.INT,
                MPReq = 2,
                INTReq = 35,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 10
            },

            [Enums.Spells.IllusionMinor] = new SpellDefinition
            {
                Spell = Enums.Spells.IllusionMinor,
                MagicSchool = MagicSchools.Illusion,
                XpCost = 150,
                TestChar = Characteristics.INT,
                MPReq = 1,
                INTReq = 35,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 10
            },

            [Enums.Spells.IllusionMass] = new SpellDefinition
            {
                Spell = Enums.Spells.IllusionMass,
                MagicSchool = MagicSchools.Illusion,
                XpCost = 400,
                TestChar = Characteristics.INT,
                MPReq = 4,
                INTReq = 40,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.FullAction,
                CastDifficulty = 0
            },

            // ============================================================
            // NECROMANCY
            // ============================================================

            [Enums.Spells.Curse] = new SpellDefinition
            {
                Spell = Enums.Spells.Curse,
                MagicSchool = MagicSchools.Necromancy,
                XpCost = 0,
                TestChar = Characteristics.INT,
                MPReq = 6,
                INTReq = 40,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.FullAction,
                CastDifficulty = -10
            },

            [Enums.Spells.Enervation] = new SpellDefinition
            {
                Spell = Enums.Spells.Enervation,
                MagicSchool = MagicSchools.Necromancy,
                XpCost = 400,
                TestChar = Characteristics.INT,
                MPReq = 4,
                INTReq = 40,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 0
            },

            [Enums.Spells.Hex] = new SpellDefinition
            {
                Spell = Enums.Spells.Hex,
                MagicSchool = MagicSchools.Necromancy,
                XpCost = 250,
                TestChar = Characteristics.INT,
                MPReq = 3,
                INTReq = 35,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 0
            },

            [Enums.Spells.LifeTransfer] = new SpellDefinition
            {
                Spell = Enums.Spells.LifeTransfer,
                MagicSchool = MagicSchools.Necromancy,
                XpCost = 250,
                TestChar = Characteristics.INT,
                MPReq = 3,
                INTReq = 35,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 20
            },

            [Enums.Spells.RaiseDead] = new SpellDefinition
            {
                Spell = Enums.Spells.RaiseDead,
                MagicSchool = MagicSchools.Necromancy,
                XpCost = 350,
                TestChar = Characteristics.INT,
                MPReq = 4,
                INTReq = 40,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.FullAction,
                CastDifficulty = -10
            },

            [Enums.Spells.RendFlesh] = new SpellDefinition
            {
                Spell = Enums.Spells.RendFlesh,
                MagicSchool = MagicSchools.Necromancy,
                XpCost = 300,
                TestChar = Characteristics.INT,
                MPReq = 4,
                INTReq = 40,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = -10
            },

            // ============================================================
            // RESTORATION
            // ============================================================

            [Enums.Spells.Cure] = new SpellDefinition
            {
                Spell = Enums.Spells.Cure,
                MagicSchool = MagicSchools.Restoration,
                XpCost = 150,
                TestChar = Characteristics.INT,
                MPReq = 2,
                INTReq = 35,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.FullAction,
                CastDifficulty = 20
            },

            [Enums.Spells.Heal] = new SpellDefinition
            {
                Spell = Enums.Spells.Heal,
                MagicSchool = MagicSchools.Restoration,
                XpCost = 250,
                TestChar = Characteristics.INT,
                MPReq = 2,
                INTReq = 30,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.FullAction,
                CastDifficulty = 20
            },

            [Enums.Spells.Regenerate] = new SpellDefinition
            {
                Spell = Enums.Spells.Regenerate,
                MagicSchool = MagicSchools.Restoration,
                XpCost = 200,
                TestChar = Characteristics.INT,
                MPReq = 3,
                INTReq = 35,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 10
            },

            // ============================================================
            // TRANSMUTATION
            // ============================================================

            [Enums.Spells.Boost] = new SpellDefinition
            {
                Spell = Enums.Spells.Boost,
                MagicSchool = MagicSchools.Transmutation,
                XpCost = 250,
                TestChar = Characteristics.INT,
                MPReq = 1,
                INTReq = 30,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 20
            },

            [Enums.Spells.Crush] = new SpellDefinition
            {
                Spell = Enums.Spells.Crush,
                MagicSchool = MagicSchools.Transmutation,
                XpCost = 300,
                TestChar = Characteristics.INT,
                MPReq = 2,
                INTReq = 35,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 10
            },

            [Enums.Spells.Expedite] = new SpellDefinition
            {
                Spell = Enums.Spells.Expedite,
                MagicSchool = MagicSchools.Transmutation,
                XpCost = 200,
                TestChar = Characteristics.INT,
                MPReq = 2,
                INTReq = 35,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 10
            },

            [Enums.Spells.FeatherFall] = new SpellDefinition
            {
                Spell = Enums.Spells.FeatherFall,
                MagicSchool = MagicSchools.Transmutation,
                XpCost = 150,
                TestChar = Characteristics.INT,
                MPReq = 2,
                INTReq = 35,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.Reaction,
                CastDifficulty = 20
            },

            [Enums.Spells.Fly] = new SpellDefinition
            {
                Spell = Enums.Spells.Fly,
                MagicSchool = MagicSchools.Transmutation,
                XpCost = 200,
                TestChar = Characteristics.INT,
                MPReq = 3,
                INTReq = 35,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 20
            },

            [Enums.Spells.Jump] = new SpellDefinition
            {
                Spell = Enums.Spells.Jump,
                MagicSchool = MagicSchools.Transmutation,
                XpCost = 100,
                TestChar = Characteristics.INT,
                MPReq = 1,
                INTReq = 35,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 0
            },

            [Enums.Spells.Longstrider] = new SpellDefinition
            {
                Spell = Enums.Spells.Longstrider,
                MagicSchool = MagicSchools.Transmutation,
                XpCost = 200,
                TestChar = Characteristics.INT,
                MPReq = 2,
                INTReq = 30,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 10
            },

            [Enums.Spells.Polymorph] = new SpellDefinition
            {
                Spell = Enums.Spells.Polymorph,
                MagicSchool = MagicSchools.Transmutation,
                XpCost = 300,
                TestChar = Characteristics.INT,
                MPReq = 4,
                INTReq = 40,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 0
            },

            [Enums.Spells.Prestidigitation] = new SpellDefinition
            {
                Spell = Enums.Spells.Prestidigitation,
                MagicSchool = MagicSchools.Transmutation,
                XpCost = 0,
                TestChar = Characteristics.INT,
                MPReq = 1,
                INTReq = 0,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 0
            },

            [Enums.Spells.RapidGrowth] = new SpellDefinition
            {
                Spell = Enums.Spells.RapidGrowth,
                MagicSchool = MagicSchools.Transmutation,
                XpCost = 200,
                TestChar = Characteristics.INT,
                MPReq = 4,
                INTReq = 0,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.FullAction,
                CastDifficulty = 30
            },

            [Enums.Spells.Rust] = new SpellDefinition
            {
                Spell = Enums.Spells.Rust,
                MagicSchool = MagicSchools.Transmutation,
                XpCost = 200,
                TestChar = Characteristics.INT,
                MPReq = 2,
                INTReq = 0,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 10
            },

            [Enums.Spells.ShapeStone] = new SpellDefinition
            {
                Spell = Enums.Spells.ShapeStone,
                MagicSchool = MagicSchools.Transmutation,
                XpCost = 250,
                TestChar = Characteristics.INT,
                MPReq = 3,
                INTReq = 40,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.HalfAction,
                CastDifficulty = 20
            },

            // ============================================================
            // UNIVERSAL
            // ============================================================

            [Enums.Spells.CircleOfTheMagi] = new SpellDefinition
            {
                Spell = Enums.Spells.CircleOfTheMagi,
                MagicSchool = MagicSchools.Universal,
                XpCost = 300,
                TestChar = Characteristics.INT,
                MPReq = 4,
                INTReq = 35,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.FullAction,
                CastDifficulty = 0
            },

            [Enums.Spells.Tongues] = new SpellDefinition
            {
                Spell = Enums.Spells.Tongues,
                MagicSchool = MagicSchools.Universal,
                XpCost = 150,
                TestChar = Characteristics.INT,
                MPReq = 1,
                INTReq = 35,
                Range = 0,
                NumTargets = 1,
                CastingTime = CastingTimes.SwiftAction,
                CastDifficulty = 10
            },

            [Enums.Spells.Wish] = new SpellDefinition
            {
                Spell = Enums.Spells.Wish,
                MagicSchool = MagicSchools.Universal,
                XpCost = 750,
                TestChar = Characteristics.INT,
                MPReq = 10,
                INTReq = 50,
                Range = 0,
                NumTargets = 0,
                CastingTime = CastingTimes.FullAction,
                CastDifficulty = -10
            }
        };
    }
}