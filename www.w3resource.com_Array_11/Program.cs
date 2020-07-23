using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = InteractiveWithUser.GetIntArray();

            Array.Sort(firstArray);

            Console.WriteLine("Elementy posortowane rosnąco");

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write(firstArray[i] + " ");
            }

            Array.Reverse(firstArray);

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write(firstArray[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
