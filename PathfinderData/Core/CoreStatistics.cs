﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderData.Core
{
    internal class CoreStatistics
    {
    }

    public class ArmorClass
    {
        public ArmorClass(int DexMod)
        {
            StatBonus = DexMod;
        }
        public int Total { get => Base + ArmorBonus + ShieldBonus + StatBonus + SizeBonus + NaturalArmor + DodgeBonus + DeflectionBonus + MiscBonus; }
        public int Touch { get => Base + StatBonus + SizeBonus + DodgeBonus + DeflectionBonus + MiscBonus; }
        public int FlatFooted { get => Base + ArmorBonus + ShieldBonus + SizeBonus + NaturalArmor + DeflectionBonus + MiscBonus; }
        public int Base { get; set; } = 10;
        public int ArmorBonus { get; set; } = 0;
        public int ShieldBonus { get; set; } = 0;
        public int StatBonus { get; set; } = 0;
        public int SizeBonus { get; set; } = 0;
        public int NaturalArmor { get; set; } = 0;
        public int DodgeBonus { get; set; } = 0;
        public int DeflectionBonus { get; set; } = 0;
        public int MiscBonus { get; set; } = 0;
        public List<Modifier> Modifiers { get; set; } = new List<Modifier>();
    }
    public class Health
    {
        public int Total { get; set; }
        public int Wounds { get; set; } = 0;
        public int NonLethal { get; set; } = 0;
           
    }
    public class SavingThrows
    {
        public Save Fortitude { get; set; }
        public Save Reflex { get; set; }
        public Save Will { get; set; }
    }
    public class Save
    {
        public int TotalValue { get; }
        public int BaseValue { get; set; }
        public int AbilityValue { get; set; }
        public int ModValue { get; set; }
    }
    public class AbilityScores
    {
        public AbilityScore Strength { get; set; }
        public AbilityScore Dexterity { get; set; }
        public AbilityScore Constitution { get; set; }
        public AbilityScore Intelligence { get; set; }
        public AbilityScore Wisdom { get; set; }
        public AbilityScore Charisma { get; set; }
    }

    public class AbilityScore
    {
        public int BaseValue { get; set; } = 0;
        public int TempValue { get; set; } = 0;
        public int ModValue { get; }
    }

    public class Modifier
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Subtype { get; set; }
        public int Mod { get; set; }
    }

    public class Skill
    {
        public string Name { get; set; } = string.Empty;
        public string Ability { get; set; } = string.Empty;
        public bool IsClassSkill { get; set; } = false;
        public int TotalMod { get => AbilityMod + Ranks + MiscMod; }
        public int AbilityMod { get; set; }
        public int Ranks { get; set; }
        public int MiscMod { get; set; }

    }
}