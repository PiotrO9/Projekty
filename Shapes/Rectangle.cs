using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        protected double side1, side2;

        public void SetSides(double SentSideOne, double SentSideTwo)
        {
            side1 = SentSideOne;
            side2 = SentSideTwo;
        }

        public override double Area()
        {
            return side1 * side2;
        }
    }

}
