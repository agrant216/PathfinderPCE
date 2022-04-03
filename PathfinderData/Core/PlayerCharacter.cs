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
            public int Strength { get; set; }
            public int Dexterity { get; set; }
            public int Constitution { get; set; }
            public int Intelligence { get; set; }
            public int Wisdom { get; set; }
            public int Charisma { get; set; }
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
