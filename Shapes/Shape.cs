using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Shape
    {
        protected Location c;

        public string ToString()
        {
            return "";
        }

        public virtual double Area()
        {
            return 0.000;
        }

        public double Perimeter()
        {
            return 0.000;
        }
    }
}
