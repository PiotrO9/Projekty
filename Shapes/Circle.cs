using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape
    {
        protected double radious = 0;

        public Circle()
        {

        }

        public Circle(double rad)
        {
            radious = rad;
        }

        public void SetRadious(double SentRadious)
        {
            radious = SentRadious;
        }

        public override double Area()
        {
            return 3.14 * (radious * radious);
        }

        public override double Perimeter()
        {
            return 2 * 3.14 * radious;
        }
    }


}
