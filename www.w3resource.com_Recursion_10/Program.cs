using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Recursion_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");

            int fib = int.Parse(Console.ReadLine());

            for (int i = 0; i < fib; i++)
            {
                Console.Write(Fibbonaci(i) + " ");
            }

            Console.ReadLine();
        }

        static int Fibbonaci(int n)
        {
            int p = 0;
            int q = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = p;
                p = q;
                q = temp + p;
            }

            return p;
        }
    }
}
