using _2020_zad._2.procedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_zad._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj pierwszą wartość: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą wartość: ");
            int b = int.Parse(Console.ReadLine());

            int i = Counting.Sym(a, b);

            Console.WriteLine("\n" + i);

            Console.ReadKey();
        }
    }
}
