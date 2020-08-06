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

        public string ToString()
        {
            return "Corner (" + l.GetX() / 2 + "), side " + l.GetSide();
        }
    }
}
