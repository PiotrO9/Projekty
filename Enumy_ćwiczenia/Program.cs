using EnumyZadania.Enumy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumyZadania
{
    class Program
    {
        static void Main(string[] args)
        {
            BorderStyle test1 = BorderStyle.right;

            BorderStyle test2 = BorderStyle.left;

            int number1 = (int)test1;
            number1 += 1;
            Console.WriteLine((int)number1);

            int number2 = (int)test2;
            number2 += 4;
            Console.WriteLine((BorderStyle)number2);

            foreach (int i in Enum.GetValues(typeof(BorderStyle)))
            {
                Console.WriteLine((BorderStyle)i);
            }

            Console.ReadLine();

        }
    }
}
