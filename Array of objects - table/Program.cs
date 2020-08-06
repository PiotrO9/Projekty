using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_of_objects___table
{
    class Program
    {
        static void Main(string[] args)
        {
            Table[] myTables = new Table[10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                myTables[i] = new Table(rnd.Next(50, 201), rnd.Next(50, 201));
                myTables[i].ShowData();
            }

            Console.ReadLine();
        }
    }
}
