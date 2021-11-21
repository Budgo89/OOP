using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6_3
{
    internal class Rectangle : Point, IArea
    {
        internal double a;
        internal double b;

        internal Rectangle(double a, double b) : base(a/2, b/2)
        {
            this.a = a;
            this.b = b;
        }
              
        public override string ToString()
        {
            return $"Прямоугольник \nЦвет {colour}. \nВидимость {visibility} \nДлина {a} \nШирина {b}";
        }

        public double Area()
        {
            return a * b;
        }
    }
}
