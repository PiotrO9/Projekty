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

            CountingDigits(number);

            Console.Read();
        }

        static void CountingDigits(int temp, int test = 0)
        {
            if (temp < 100)
            {
                Console.WriteLine(test);
            }
            else
            {
                test++;
                CountingDigits(temp / 10);
            }
        }
    }
}
