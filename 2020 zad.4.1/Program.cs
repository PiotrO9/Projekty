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
            //string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            //string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);

            string[] lines = File.ReadAllLines("pary.txt");
            int length = lines.Length;

            string[] convertedLines = new string[length];

            int i = 0;

            foreach (var line in lines)
            {
                Console.WriteLine("\t" + line);

                bool number = Char.IsNumber(line[1]);

                if (number == true)
                {
                    convertedLines[i] = line[0].ToString() + line[1].ToString();
                }
                else
                {
                    convertedLines[i] = line[0].ToString();
                }
                i++;
            }

            foreach (var item in convertedLines)
            {
                Console.WriteLine(item);
            }


            foreach (var item in convertedLines)
            {
                int n = int.Parse(item);

                if (n % 2 == 0)
                {
                    Console.WriteLine(primals.Primals(n));
                }
            }

            Console.ReadLine();
        }
    }
}
