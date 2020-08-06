using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_DateTime_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;

            DateTime testDT = new DateTime(2016);

            if (isIntercalary(dt) == true)
            {
                Console.WriteLine("Podany rok to rok przestępny");
            }
            else
            {
                Console.WriteLine("Podany rok nie jest rokiem przestpnym");
            }

            if (isIntercalary(testDT) == true)
            {
                Console.WriteLine("Podany rok to rok przestępny");
            }
            else
            {
                Console.WriteLine("Podany rok nie jest rokiem przestpnym");
            }

            Console.ReadLine();

        }

        static bool isIntercalary(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                return true;
            }

            return false;
        }
    }
}
