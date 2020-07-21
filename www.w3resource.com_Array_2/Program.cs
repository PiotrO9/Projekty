using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            int[] array1 = new int[loops];

            for (int i = 0; i < loops; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = array1.Length; i > 0; i--)
            {
                Console.WriteLine(array1[i - 1]);
            }

            Console.ReadLine();

        }
    }
}
