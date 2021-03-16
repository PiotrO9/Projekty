using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorWPF.Engines
{
    public static class MinusIncluded
    {
        public static bool CheckIfMinusIncluded(string s)
        {
            bool temp = false; // Jeżeli nie wystąpi - false

            foreach (var letter in s)
            {
                if (letter == '-')
                {
                    temp = true; //Jeżeli minus wystąpi - true
                }
            }

            return temp;
        }
    }
}
