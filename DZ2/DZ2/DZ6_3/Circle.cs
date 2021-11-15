using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6_3
{
    internal class Circle : Point
    {
        internal Point сentre;
        internal double radius;

        internal Circle(double x, double y, double radius) : base (x,y)
        {
            this.сentre = new Point(x, y);
            this.radius = radius;
        }
        public override string ToString()
        {
            return $"Круг \nЦвет {colour}. \nВидимость {visibility} \nКоординаты по X и Y: {сentre} \nРадиус {radius}";
        }

        internal double AreaOfACircle()
        {
            return Math.PI * Math.Pow(radius,2);
        }
    }
}
