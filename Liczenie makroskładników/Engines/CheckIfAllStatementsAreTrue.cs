using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczenie_makroskładników.Engines
{
    static class CheckIfAllStatementsAreTrue
    {
        public static bool CheckIfAllStatementsAreTrueMethod(bool[] array)
        {
            int Length = array.Length;

            for (int i = 0; i < Length; i++)
            {
                if(array[i] == false)
                {
                    return false;
                }
                else
                {
                    continue;
                }
            }

            return true;
        }
    }
}
