using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_DateTime_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2016, 8, 6, 11, 49, 0);
            Console.WriteLine("Complete date: " + dt.ToString());
            DateTime dateonly = dt.Date;
            Console.WriteLine("Short Date: " + dateonly.ToString("d"));

            Console.WriteLine(dateonly.ToString("g"));
            Console.WriteLine(dateonly.ToString("MM/dd/yyyy HH:mm"));

            Console.ReadLine();
        }
    }
}
