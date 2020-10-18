using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Recursion_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(number));

            Console.ReadLine();

        }

        static int Factorial(int n, int s = 1)
        {
            if (n == 1)
            {
                return s;
            }
            else
            {
                s *= n;
                n--;

                return Factorial(n, s);
            }
        }
    }
}
