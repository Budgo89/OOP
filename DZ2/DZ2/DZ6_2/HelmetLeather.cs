using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6_2
{
    internal class HelmetLeather : LeatherArmor
    {
        internal HelmetLeather(double _armor)
        {
            armor = _armor;
            armorType = (ArmorType)1;
            typeTrotection = 0;
        }
    }
}
