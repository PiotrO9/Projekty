using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Function_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (IfPrime(number) == true)
            {
                Console.WriteLine("Podana liczba to liczba pierwsza");
            }
            else
            {
                Console.WriteLine("Podana liczba nie jest liczbą pierwszą");
            }

            Console.ReadLine();
        }

        static bool IfPrime(int n)
        {
            if (n <= 0)
            {
                return false;
            }

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
