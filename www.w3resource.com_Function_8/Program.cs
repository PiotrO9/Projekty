using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Function_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Fib(number);

            Console.Read();
        }

        static void Fib(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Podana liczba jest ujemna");
                return;
            }
            else if (n == 0)
            {
                Console.WriteLine("Podana liczba wynosi 0");
                return;
            }

            int[] FibbonaciArray = new int[n];

            FibbonaciArray[0] = 0;
            FibbonaciArray[1] = 1;

            for (int i = 2; i < FibbonaciArray.Length; i++)
            {
                FibbonaciArray[i] = FibbonaciArray[i - 1] + FibbonaciArray[i - 2];
            }

            for (int i = 0; i < FibbonaciArray.Length; i++)
            {
                Console.Write(FibbonaciArray[i].ToString() + " ");
            }
        }
    }
}
