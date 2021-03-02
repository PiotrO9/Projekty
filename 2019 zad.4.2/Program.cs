using _2019_zad._4._2.engines;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_zad._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("liczby.txt");
            int[] FactorialLines = new int[lines.Count()];

            foreach (var line in lines)
            {
                int length = line.Length;

                int[] FactorialNumbers = new int[length];

                for (int i = 0; i < length; i++)
                {
                    int n = int.Parse(line[i].ToString());
                    FactorialNumbers[i] = factorial.Factorial(n);
                }

                int sum = 0;

                for (int i = 0; i < FactorialNumbers.Length; i++)
                {
                    sum += FactorialNumbers[i];
                }

                if (sum == int.Parse(line))
                {
                    Console.WriteLine(sum);
                }

            }


            Console.ReadKey();
        }
    }
}
