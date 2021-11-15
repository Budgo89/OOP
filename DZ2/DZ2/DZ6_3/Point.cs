using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6_3
{
    internal class Point : Figure
    {
        internal double x;
        internal double y;

        internal Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            this.visibility = true;
            this.colour = "white";
        }

        public override string ToString()
        {
            return $"{x} {y}";
        }
    }
}
