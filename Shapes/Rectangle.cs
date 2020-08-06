using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        protected double side1 = 0, side2 = 0;

        public Rectangle()
        {

        }
        public Rectangle(double s1, double s2)
        {
            side1 = s1;
            side2 = s2;
        }

        public void SetSides(double SentSideOne, double SentSideTwo)
        {
            side1 = SentSideOne;
            side2 = SentSideTwo;
        }

        public override double Area()
        {
            return side1 * side2;
        }

        public override double Perimeter()
        {
            return (2 * side1) + (2 * side2);
        }
    }

}
