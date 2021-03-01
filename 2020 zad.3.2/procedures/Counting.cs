using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_zad._3._2.procedures
{
    class Counting
    {
        public static void Count(int n, int w = 0)
        {
            while (n != 0)
            {
                w += (n % 10);
                n = n / 10;
            }

            Console.WriteLine("n = " + n + ", w = " + w);
        }

    }
}
