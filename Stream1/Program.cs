using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "testing123";

            StreamWriter sw = new StreamWriter("test.txt");

            sw.WriteLine(s);
            sw.Close();

            StreamReader sr= new StreamReader("test.txt");

            Console.WriteLine(sr.ReadLine());

            sr.Close();

            Console.ReadKey();
        }
    }
}
