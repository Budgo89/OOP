using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6_2
{
    internal class ChestPlate : PlateArmor
    {
        internal ChestPlate(double _armor)
        {
            armor = _armor;
            armorType = (ArmorType)2;
            typeTrotection = (TypeTrotection)1;
        }
    }
}
