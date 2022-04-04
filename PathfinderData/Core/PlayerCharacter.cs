using PathfinderData.Classes.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderData.Core
{
    [Serializable]
    internal class PlayerCharacter
    {
        public PlayerCharacter()
        {
            AbilityScores = new AbilityScores();
            AC = new ArmorClass(AbilityScores.Dexterity.ModValue);
            HitPoints = new Health();
        }
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; } = 1;
        public Dictionary<int, ClassLevel> ClassLevels { get; set; } = new Dictionary<int, ClassLevel>();
        public Health HitPoints { get; set; }
        public AbilityScores AbilityScores { get; set; }
        public ArmorClass AC { get; set; }
        public List<Skill> Skills { get; set; } = new List<Skill>();
        public List<Modifier> Modifiers { get; set; } = new List<Modifier>();

    }
        
}
