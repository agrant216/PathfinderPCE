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
            AC = new ArmorClass(AbilityScores.Abilities["Dexterity"].ModValue);
            HitPoints = new Health();
            Skills = new Skills();
        }
        public Guid id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; } = 1;
        public Dictionary<int, ClassLevel> ClassLevels { get; set; } = new Dictionary<int, ClassLevel>();
        public Health HitPoints { get; set; }
        public AbilityScores AbilityScores { get; set; }
        public ArmorClass AC { get; set; }
        public Skills Skills { get; set; }
        public List<Modifier> GetAllModifiers() 
        { 
            return new List<Modifier>(); 
        }

    }
        
}
