using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_application.services
{
    static class CheckIfEmpty
    {
        public static bool Method(string number, string password)
        {
            if (number != string.Empty && password != string.Empty)
                return true;

            return false;
        }
    }
}
