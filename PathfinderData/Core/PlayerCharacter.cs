using PathfinderData.Classes.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderData.Core
{
    [Serializable]
    public class PlayerCharacter
    {
        public PlayerCharacter()
        {

            AbilityScores = new AbilityScores();
            AC = new ArmorClass(AbilityScores.Dexterity.ModValue);
            HitPoints = new Health();
        }
        public Guid id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; } = 1;
        public Dictionary<int, ClassLevel> ClassLevels { get; set; } = new Dictionary<int, ClassLevel>();
        public Health HitPoints { get; set; }
        public AbilityScores AbilityScores { get; set; }
        public ArmorClass AC { get; set; }
        public Dictionary<string,Skill> Skills { get; set; } = new Dictionary<string,Skill>()
        {
            {"Acrobatics", new Skill("Acrobatics", "Dexterity") },
            {"Appraise", new Skill("Appraise", "Intelligence") },
            {"Bluff", new Skill("Bluff", "Charisma") },
            {"Climb", new Skill("Climb", "Strength") },
            {"Craft", new Skill("Craft", "Intelligence") },
            {"Diplomacy", new Skill("Diplomacy", "Charisma") },
            {"Disable Device", new Skill("Disable Device", "Dexterity") },
            {"Disguise", new Skill("Disguise", "Charisma") },
            {"Escape Artist", new Skill("Escape Artist", "Dexterity") },
            {"Fly", new Skill("Fly", "Dexterity") },
            {"Handle Animal", new Skill("Handle Animal", "Charisma") },
            {"Heal", new Skill("Heal", "Wisdom") },
            {"Intimidate", new Skill("Intimidate", "Charisma") },
            {"Knowledge (arcana)", new Skill("Knowledge (arcana)", "Intelligence") },
            {"Knowledge (dungeoneering)", new Skill("Knowledge (dungeoneering)", "Intelligence") },
            {"Knowledge (engineering)", new Skill("Knowledge (engineering)", "Intelligence") },
            {"Knowledge (geography)", new Skill("Knowledge (geography)", "Intelligence") },
            {"Knowledge (history)", new Skill("Knowledge (history)", "Intelligence") },
            {"Knowledge (local)", new Skill("Knowledge (local)", "Intelligence") },
            {"Knowledge (nature)", new Skill("Knowledge (nature)", "Intelligence") },
            {"Knowledge (nobility)", new Skill("Knowledge (nobility)", "Intelligence") },
            {"Knowledge (planes)", new Skill("Knowledge (planes)", "Intelligence") },
            {"Knowledge (religion)", new Skill("Knowledge (religion)", "Intelligence") },
            {"Linguistics", new Skill("Linguistics", "Intelligence") },
            {"Perception", new Skill("Perception", "Wisdom") },
            {"Perform", new Skill("Perform", "Charisma") },
            {"Profession", new Skill("Profession", "Wisdom") },
            {"Ride", new Skill("Ride", "Dexterity") },
            {"Sense Motive", new Skill("Sense Motive", "Wisdom") },
            {"Sleight of Hand", new Skill("Sleight of Hand", "Dexterity") },
            {"Spellcraft", new Skill("Spellcraft", "Intelligence") },
            {"Stealth", new Skill("Stealth", "Dexterity") },
            {"Survival", new Skill("Survival", "Wisdom") },
            {"Swim", new Skill("Swim", "Strength") },
            {"Use Magic Device", new Skill("Use Magic Device", "Charisma") },
        };
        public List<Modifier> Modifiers { get; set; } = new List<Modifier>();

    }
        
}
