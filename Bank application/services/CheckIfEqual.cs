using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_application.services
{
    static class CheckIfEqual
    {
        public static bool Method(string number, string password)
        {
            if (number == password)
            {
                return true;
            }
            else
                return false;
        }
    }
}
