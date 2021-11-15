using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6_3
{
    internal class Figure
    {
        internal string colour;
        internal bool visibility;

        internal void HorizontalMovement()
        {
            throw new NotImplementedException();
        }
        internal void VerticalMovement()
        {
            throw new NotImplementedException();
        }
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
