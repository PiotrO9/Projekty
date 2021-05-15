using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_function
{
    static class quadratic_function
    {
        private static List<double> _resultList = new List<double>();

        public static List<double> Method(double a,double b,double c)
        {
            double d = 0;
            d = Math.Pow(b, 2) - 4 * a * c;

            if(d == 0)
            {
                double s = Math.Sqrt(d);

                double x1 = (-b - s) / (2 * a);
                _resultList.Add(x1);
            }
            else if(d > 0)
            {
                double s = Math.Sqrt(d);

                double x1 = (-b - s) / (2 * a);
                double x2 = (-b  + s) / (2 * a);

                _resultList.Add(x1);
                _resultList.Add(x2);
            }

            return _resultList;
        }
    }
}






