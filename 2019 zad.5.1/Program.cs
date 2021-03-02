using _2019_zad._5._1.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_zad._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("pogoda.txt");

            List<Note> Notes = new List<Note>();

            foreach (var item in text)
            {
                if (item == text[0])
                {
                    break;
                }

                string s = item;

                Note note = new Note(); //stworzenie modelu

                string CloudSize = s.Substring(s.Length - 1); //pobieranie wartości cloudsize
                s.Remove(s.Length - 2, 2); // usuwanie ostatniego znaku

                string CloudCategory = s.Substring(s.Length - 1);
                s.Remove(s.Length - 2, 2);

                int Fall = 0;

                if (Char.IsNumber(s[s.Length - 1]) == true)
                {
                    string temp = s[s.Length].ToString() + s[s.Length - 1].ToString();
                    Fall = int.Parse(temp);
                    s.Remove(s.Length - 3, 3);
                }
                else
                {
                    Fall = int.Parse(s[s.Length].ToString());
                    s.Remove(s.Length - 2, 2);
                }


            }

            Console.ReadKey();
        }
    }
}
