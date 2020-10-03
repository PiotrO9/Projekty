using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Recursion_3
{
    class Program
    {
        readonly static int number = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ilość liczb do zsumowania: ");

            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Recursion(1, 10));

            Console.ReadLine();
        }

        static int Recursion(int min, int val)
        {
            if (val == min)
            {
                return val;
            }

            return val + Recursion(min, val - 1);
        }
    }
}
