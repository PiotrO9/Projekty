using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> test = new List<int>();
            test.Add(0);
            for (; ; )
            {
                Console.WriteLine(test[0]);
                Console.WriteLine("Podaj liczbę");

                test[0] = int.Parse(Console.ReadLine());
            }

        }
    }
}
