﻿using _2019_zad._5._1.models;
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
            string[] lines = File.ReadAllLines("pogoda.txt");

            List<Note> Notes = new List<Note>();

            foreach (var line in lines.Skip(1))
            {
                var item = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
                var newNote = new Note();

                try
                {
                    newNote.Day = int.Parse(item[0]);
                    newNote.Temperature = float.Parse(item[1]);
                    newNote.Falls = int.Parse(item[2]);
                    newNote.CloudCategory = Convert.ToChar(item[3]);
                    newNote.CloudSize = int.Parse(item[4]);

                }
                catch (FormatException e)
                {
                    Console.WriteLine("");
                }

                Notes.Add(newNote);
            }

            IEnumerable<Note> query = Notes.Where(note => note.Temperature >= 20 && note.Falls <= 5);

            int amount = query.Count();

            Console.WriteLine(amount);

            Console.ReadKey();
        }
    }
}
