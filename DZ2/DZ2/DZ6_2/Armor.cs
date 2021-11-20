using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6_2
{
    internal class Armor
    {
        internal double armor;
        internal double strength = 100;

        internal virtual double DecreasedStrength(double hp, int damage)
        {
            return hp;
        }
        internal void Repair()
        {
            strength = 100;
        }
    }
}
