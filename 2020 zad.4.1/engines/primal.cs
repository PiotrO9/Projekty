using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_zad._4._1.engines
{
    public static class primal
    {
        public static bool Primal(int n)
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
