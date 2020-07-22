using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            int[] array1 = new int[loops];

            int sum = 0;

            for (int i = 0; i < loops; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < loops; i++)
            {
                sum += array1[i];
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
