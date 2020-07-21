using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int number = int.Parse(input);

            int[] array1 = new int[number];

            for(int i=0;i<number;i++)
            {
                if(i == 0)
                {
                    array1[i] = 1;
                }
                else
                {
                    array1[i] = i;
                }
            }

            for(int i = 0;i<number;i++)
            {
                Console.WriteLine(array1[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
