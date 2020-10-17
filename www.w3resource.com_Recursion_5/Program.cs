using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Recursion_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            CountingDigits(number, 0);

            Console.Read();
        }

        static void CountingDigits(int temp, int test)
        {
            if (temp == 0)
            {
                Console.WriteLine(test);
            }
            else
            {
                test++;
                CountingDigits(temp / 10, test);
            }
        }
    }
}
