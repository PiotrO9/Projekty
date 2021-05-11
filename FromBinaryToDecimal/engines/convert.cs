using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromBinaryToDecimal.engines
{
    static class convert
    {
        public static double Method(string s)
        {
            int length = s.Length;

            int power = length - 1;

            double sum = 0;

            for (int i = 0; i < length; i++)
            {
                int tempNumber = int.Parse(s[i].ToString());

                sum += tempNumber * Math.Pow(2, power);
                power--;
            }

            return sum;
        }
    }
}
