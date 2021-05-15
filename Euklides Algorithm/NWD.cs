using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euklides_Algorithm
{
    static class NWD
    {
        public static int Method(int n,int m)
        {
            while(m != 0)
            {
                int temp = m;
                m = n % m;
                n = temp;
            }

            return n;
        }
    }
}
