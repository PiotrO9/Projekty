using _2020_zad._3._2.procedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_zad._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj parametry n,w: ");
            Console.Write("N: ");

            int n = int.Parse(Console.ReadLine());
            Console.Write("W: ");

            int w = int.Parse(Console.ReadLine());

            Counting.Count(n, w);

            Console.ReadLine();
        }
    }
}
