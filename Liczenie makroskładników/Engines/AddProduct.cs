using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczenie_makroskładników.Engines
{
     static class AddProduct
    {
        public static void AddProductMethod(string[] s)
        {
            int length = s.Length;

            string temp = "\n";

            for (int i = 0; i < length; i++)
            {
                temp += s[i];
                temp += ';';
            }

            temp = temp.Remove(temp.Length - 1);

            string text = File.ReadAllText("produkty.txt");

            string conc = text + temp ;

            File.WriteAllText("produkty.txt", conc);
        }
    }
}
