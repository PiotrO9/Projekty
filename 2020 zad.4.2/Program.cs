using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _2020_zad._4._2.models;

namespace _2020_zad._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("pary.txt");
            int length = lines.Length;

            string[] ConvertedLines = new string[length];
            int l = 0;

            foreach (var line in lines)
            {
                bool number = char.IsNumber(line[1]);

                if (number == true)
                {
                    ConvertedLines[l] = line.Remove(0, 3);
                }
                else
                {
                    ConvertedLines[l] = line.Remove(0, 2);
                }

                l++;
            }

            foreach (var item in ConvertedLines)
            {
                Console.WriteLine(item);
                engine engine = new engine();
                StringOfCharacters stringOfCharacters = engine.Cut(item);

                string s = stringOfCharacters.text + " " + stringOfCharacters.length.ToString() + "\n";

                Console.Write(s);
            }



            Console.ReadKey();

        }
    }
}
