using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Recursion_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");
            int number = int.Parse(Console.ReadLine());

            PrintingOddNumbers(1, number - 1);

            Console.ReadLine();
        }

        static int PrintingOddNumbers(int s, int n)
        {
            if (n < 1)
            {
                return s;
            }
            n -= 2;

            Console.Write(s + 1 + " ");


            return PrintingOddNumbers(s + 2, n);
        }
    }
}
