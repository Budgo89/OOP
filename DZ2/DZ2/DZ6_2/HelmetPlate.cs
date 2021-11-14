using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6_2
{
    internal class HelmetPlate : PlateArmor
    {
        internal HelmetPlate(double _armor)
        {
            armor = _armor;
            armorType = (ArmorType)2;
            typeTrotection = 0;
        }
    }
}
