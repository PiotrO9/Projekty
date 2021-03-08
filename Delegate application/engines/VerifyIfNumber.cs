using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_application.engines
{
    public static class VerifyIfNumber
    {
        public static bool Veryfication(string s1, string s2)
        {
            bool v1;
            bool v2;

            if (int.TryParse(s1, out int test1) == true)
            {
                v1 = true;
            }
            else
            {
                v1 = false;
            }

            if (int.TryParse(s2, out int test2) == true)
            {
                v2 = true;
            }
            else
            {
                v2 = false;
            }

            if (v1 == true && v2 == true)
                return true;
            else
                return false;
        }

    }
}
