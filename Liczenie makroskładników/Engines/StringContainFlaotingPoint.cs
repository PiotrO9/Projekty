using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczenie_makroskładników.Engines
{
    static class StringContainFlaotingPoint
    {
        public static bool StringContainFlaotingPointMethod(string s)
        {
            int Length = s.Length;

            if(Length == 0)
            {
                return false;
            }

            for (int i = 0; i < Length; i++)
            {
                if(s[i] == ',')
                {
                    return true;
                }
            }

            return false;
        }
    }
}
