using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderData.Core.Interfaces
{
    internal interface IModifiable
    {
        List<Modifier> Modifiers { get; }
        void CalculateModifiers();
    }
}
