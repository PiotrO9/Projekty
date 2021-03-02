
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_zad._4._1.Engines
{
    public class exponentiation
    {
        static public bool Isexponentiation(int n)
        {
            List<int> numbers = new List<int>();

            int t = 1;

            while (t < 100000)
            {
                numbers.Add(t);
                t *= 3;
            }

            foreach (var number in numbers)
            {
                if (number > n)
                    return false;

                if (n == number)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
