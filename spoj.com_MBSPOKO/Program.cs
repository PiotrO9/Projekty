using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj.com_MBSPOKO
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            for(int i=0; i<loops; i++)
            {
                int numberInput = int.Parse(Console.ReadLine());

                if(divisionBy3(numberInput) == true)
                {
                    if (divisionBy5(numberInput) == true)
                    {
                        Console.WriteLine("SPOKOKOKO");
                    }
                    else
                    {
                        Console.WriteLine("KOKO");
                    }
                }
                else if(divisionBy5(numberInput) == true && divisionBy3(numberInput) == false)
                {
                    Console.WriteLine("SPOKO");
                }
                else 
                {
                    Console.WriteLine(numberInput);
                }
            }
        }

        static bool divisionBy3 (int number)
        {
            if(number % 3 == 0)
            {
                return true;
            }
            return false;
        }

        static bool divisionBy5(int number)
        {
            if (number % 5 == 0)
            {
                return true;
            }
            return false;
        }

    }
}
