using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace To_do_list.Engines
{
    public static class ConnectTwoStringArrays
    {
        public static string[] Method(string[] firstArray, string[] secondArray)
        {
            var result = firstArray.Concat(secondArray).ToArray();

            return result;
        }
    }
}
