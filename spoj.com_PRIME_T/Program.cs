using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj.com_PRIME_T
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbęi sprawdź czy jest liczbą pierwszą: ");

                string testInput = Console.ReadLine();
            int liczba = int.Parse(testInput);

               

        }

        bool pierwsza(int number)
        {
            if(number<2)
            { return false; }
            
            for(int i=2;i*i<=number;i++)
            {
                return true;
            }

            return false;
        }
    }
}
