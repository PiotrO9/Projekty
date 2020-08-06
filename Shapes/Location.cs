using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Location
    {
        private double x;
        private double y;
        private double side;

        public void SetX(double sentX)
        {
            x = sentX;
        }
        public void SetY(double sentY)
        {
            y = sentY;
        }

        public void SetSide(double sentSide)
        {
            side = sentSide;
        }

        public double GetX()
        {
            return x;
        }

        public double GetY()
        {
            return y;
        }
        public double GetSide()
        {
            return side;
        }
    }


}
