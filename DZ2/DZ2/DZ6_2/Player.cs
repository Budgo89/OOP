using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6_2
{
    internal class Player
    {
        internal double hp;
        internal List<Armor> set;

        internal Player(double _hp, List<Armor> _set)
        {
            hp = _hp;
            set = _set;
        }

        internal void TakingDamage(int damage)
        {
            foreach (var item in set)
            {
                hp = item.DecreasedStrength(hp, damage);
            }
        }
        public override string ToString()
        {
            string plaer = $"Кол-во здоровья персонажа {hp} \n";
            foreach (var item in set)
            {
                plaer = plaer + item.ToString();
            }
            return plaer;
        }
    }


}
