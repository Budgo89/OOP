using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6_3
{
    abstract internal class Figure
    {
        internal string colour;
        internal bool visibility;

        abstract internal void HorizontalMovement(int x);
        abstract internal void VerticalMovement(int y);
        internal void ChangeColor(string colour)
        {
            this.colour = colour;
        }
        internal bool StateOfVisibility()
        {
            return visibility;
        }
        public override string ToString()
        {
            return $"Цвет {colour}. \nВидимость {visibility}";
        }
    }
}
