using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromDecimalToBinary.engines
{
    static class validate
    {
        public static bool Validate(string s)
        {
            int length = s.Length;

            for (int i = 0; i < length; i++)
            {
                if(s[i] == '0' || s[i] == '1')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
