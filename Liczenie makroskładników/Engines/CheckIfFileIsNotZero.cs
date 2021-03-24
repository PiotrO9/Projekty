using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczenie_makroskładników.Engines
{
    public static class CheckIfFileIsNotZero
    {
        public static bool CheckIfFileIsNotZeroFunction()
        {
            string temp = File.ReadAllText("ilosc.txt");

            if(temp == string.Empty)
            {
                return false; // plik nie zawiera jescze ilosci
            }
            else
            {
                return true; // plik zawiera ilość
            }
        }

    }
}
