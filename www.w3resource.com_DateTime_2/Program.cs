using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_DateTime_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = new DateTime(2016, 8, 16, 3, 57, 32, 11);

            Console.WriteLine("year = " + current.Year);

            Console.WriteLine("month = " + current.Month);

            Console.WriteLine("day = " + current.Day);

            Console.WriteLine("hour = " + current.Hour);

            Console.WriteLine("minute = " + current.Minute);

            Console.WriteLine("secound = " + current.Second);

            Console.WriteLine("millisecound = " + current.Millisecond);

            Console.ReadLine();
        }
    }
}
