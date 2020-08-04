using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_DateTime_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2016, 8, 6);

            Console.WriteLine("Dzień tygodnia: " + dt.DayOfWeek);

            Console.ReadLine();
        }
    }
}
