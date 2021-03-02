using _2019_zad._4._1.Engines;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_zad._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("liczby.txt");

            int[] NumberLines = new int[lines.Count()];

            int j = 0;

            foreach (var line in lines)
            {
                NumberLines[j] = int.Parse(line);
                j++;
            }

            int amountOfFactorialNumbers = 0;

            foreach (var number in NumberLines)
            {
                if (exponentiation.Isexponentiation(number) == true)
                {
                    amountOfFactorialNumbers++;
                }
            }

            Console.WriteLine(amountOfFactorialNumbers);
            Console.ReadLine();
        }
    }
}
