using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczenie_makroskładników.Engines
{
    public static class CheckIfFileIsEmpty
    {
        public static bool CheckIfEmpty(string s)
        {
            if (s == string.Empty) // jeżeli pusty to true
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
