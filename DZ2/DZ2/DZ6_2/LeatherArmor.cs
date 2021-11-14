using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6_2
{
    internal class LeatherArmor : Armor
    {
        internal ArmorType armorType;
        internal TypeTrotection typeTrotection;
        private double typeTrotectionVolum;

        internal override double DecreasedStrength(double hp, int damage)
        {
            if (armorType == (ArmorType)1)
            {
                if (typeTrotection == 0) typeTrotectionVolum = 0.8;
                else if (((int)typeTrotection) == 1) typeTrotectionVolum = 1;
                else typeTrotectionVolum = 0.6;

                double armorTypeVolum = 0.4;
                if (damage >= armor)
                {
                    hp = hp - (damage - armor) / armorTypeVolum * typeTrotectionVolum;
                }
                strength = strength - 5;
            }
            return hp;
        }
        public override string ToString()
        {
            return $"Тип брони {typeTrotection} \nБроня {armor} \nПрочность {strength} \nКласс брони {armorType} \n";
        }
    }
}
