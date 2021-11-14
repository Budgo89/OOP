using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6_2
{
    internal class HelmetCloth : ClothArmor
    {
        internal HelmetCloth(double _armor)
        {
            armor = _armor;
            armorType = 0;
            typeTrotection = 0;
        }
    }
}
