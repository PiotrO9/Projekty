using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3resource.com_exercise_array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            int[] array1 = new int[loops];

            for (int i = 0; i < loops; i++)
            {
                if (i == 0)
                {
                    array1[i] = 1;
                }
                else
                {
                    array1[i] = i;
                }

            }

            Console.WriteLine("----------------------");

            for (int i = 0; i < loops; i++)
            {
                Console.WriteLine(array1[i] + " ");
            }

            Console.ReadLine();

        }
    }
}
