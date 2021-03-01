using _2020_zad._4._1.engines;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_zad._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\praktyki\Desktop\przyklad.txt");

            foreach (var line in lines)
            {
                Console.WriteLine("\t" + line);
            }


            Console.ReadLine();
        }
    }
}
