﻿using System;
using Crpg.Domain.Entities.Characters;
using Crpg.Domain.Entities.Users;

namespace Crpg.Application.Common
{
    public class Constants
    {
        public float[] WeaponProficiencyPointsForAgilityCoefs { get; set; } = Array.Empty<float>();
        public float[] WeaponProficiencyPointsForWeaponMasterCoefs { get; set; } = Array.Empty<float>();
        public float[] WeaponProficiencyPointsForLevelCoefs { get; set; } = Array.Empty<float>();
        public float[] WeaponProficiencyCostCoefs { get; set; } = Array.Empty<float>();
        public float DefaultExperienceMultiplier { get; set; }
        public float[] ExperienceMultiplierForGenerationCoefs { get; set; } = Array.Empty<float>();
        public float[] RespecializeExperiencePenaltyCoefs { get; set; } = Array.Empty<float>();
        public int MinimumRetirementLevel { get; set; }
        public float[] ItemRepairCostCoefs { get; set; } = Array.Empty<float>();
        public float ItemBreakChance { get; set; }
        public float[] ItemSellCostCoefs { get; set; } = Array.Empty<float>();
        public int MinimumLevel { get; set; }
        public int MaximumLevel { get; set; }
        public float[] ExperienceForLevelCoefs { get; set; } = Array.Empty<float>();
        public int DefaultStrength { get; set; }
        public int DefaultAgility { get; set; }
        public int DefaultHealthPoints { get; set; }
        public string DefaultCharacterBodyProperties { get; set; } = string.Empty;
        public CharacterGender DefaultCharacterGender { get; set; }
        public int DefaultGeneration { get; set; }
        public bool DefaultAutoRepair { get; set; }
        public int AttributePointsPerLevel { get; set; }
        public int SkillPointsPerLevel { get; set; }
        public float[] HealthPointsForStrengthCoefs { get; set; } = Array.Empty<float>();
        public float[] HealthPointsForIronFleshCoefs { get; set; } = Array.Empty<float>();
        public float[] DamageForPowerStrikeCoefs { get; set; } = Array.Empty<float>();
        public float[] DamageForPowerDrawCoefs { get; set; } = Array.Empty<float>();
        public float[] DamageForPowerThrowCoefs { get; set; } = Array.Empty<float>();
        public float[] DurabilityForShieldCoefs { get; set; } = Array.Empty<float>();
        public float[] SpeedForShieldCoefs { get; set; } = Array.Empty<float>();
        public Role DefaultRole { get; set; }
        public int DefaultGold { get; set; }
        public int DefaultHeirloomPoints { get; set; }
    }
}