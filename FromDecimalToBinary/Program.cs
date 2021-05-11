using FromDecimalToBinary.engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromDecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Podaj liczbę w systemie dziesiętnym");

                int number = 0;

                if (int.TryParse(Console.ReadLine(), out number) == true) 
                {
                    Console.WriteLine(convert.Method(number) + "\n");
                }
            else
                {
                    Console.WriteLine("Podana liczba nie jest w systemie dziesiętnym" + "\n");
                    
                }

            }

        }
    }
}
