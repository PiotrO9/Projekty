using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shape
    {
        Location l = new Location();

        private double side = 0;

        public Square(double s)
        {
            side = s;
        }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return side * 4;
        }

        public void setSide(double s)
        {
            side = s;
        }

        public Square(double x, double y, double side)
        {
            l.SetX(x);
            l.SetY(y);
            l.SetSide(side);
        }

        public void Move(double x, double y)
        {
            l.SetX(x);
            l.SetY(y);
        }

        public void Scale(int factor)
        {
            l.SetSide(l.GetSide() * factor);
        }

        public override string ToString()
        {
            return "Corner (" + l.GetX() / 2 + "), side " + l.GetSide();
        }
    }
}
