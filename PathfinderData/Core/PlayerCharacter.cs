using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderData.Core
{
    internal class PlayerCharacter
    {
        public string Name { get; set; }

        public Attributes Base { get; set; }

        public Attributes Temporary { get; set; }

        public Dictionary<string, Modifier> Modifiers { get; set; }

        public class Attributes
        {
            public Stat Strength { get; set; }
            public Stat Dexterity { get; set; }
            public Stat Constitution { get; set; }
            public Stat Intelligence { get; set; }
            public Stat Wisdom { get; set; }
            public Stat Charisma { get; set; }
        }

        public class Stat
        {
            public int BaseValue { get; set; } = 0;
            public int TempValue { get; set; } = 0;
            public int ModValue { get; set; } = 0;
        }

        public class Modifier
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public string Subtype { get; set; }
            public int Mod { get; set; }
        }
    }
}
