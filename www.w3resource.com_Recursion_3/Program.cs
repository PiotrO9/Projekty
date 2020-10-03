using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Recursion_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Podaj ilość liczb do zsumowania: ");

                int number = int.Parse(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("Wynik to: " + Recursion(1, number));
            }
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
