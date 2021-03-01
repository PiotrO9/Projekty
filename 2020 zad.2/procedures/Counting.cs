using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_zad._2.procedures
{
    public static class Counting
    {
        static int i = 0;

        public static int Sym(int a, int b)
        {

            if (a != 0)
            {
                Sym(a - 1, b + 1);
                Console.Write(a * b + " ");
                i++;
                Sym(a - 1, b + 1);
            }

            return i;
        }
    }
}
