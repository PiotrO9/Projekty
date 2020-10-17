using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Recursion_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");

            int number = int.Parse(Console.ReadLine());

            if (Factors(number, number / 2) == true)
            {
                Console.WriteLine("Podana liczba to liczba pierwsza !");
            }
            else
            {
                Console.WriteLine("Podana liczba nie jest liczbą pierwszą !");
            }

            Console.ReadLine();
        }

        static bool Factors(int number, int temp)
        {
            if (temp == 1)
            {
                return true;
            }
            else
            {
                if (number % temp == 0)
                {
                    return false;
                }
                else
                {
                    return Factors(number, temp - 1);
                }
            }
        }
    }
}
