using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_zad._4._1.engines
{
    class primals
    {
        public static string Primals(int n)
        {
            for (int i = n - 1; i > 0; i--)
            {
                if (primal.Primal(i) == true)
                {
                    if (primal.Primal(n - i) == true)
                    {
                        string s = n.ToString() + " " + i.ToString() + " " + (n - i).ToString();
                        return s;
                    }
                }
            }

            return n.ToString();
        }

    }
}
