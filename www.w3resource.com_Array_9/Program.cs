using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = InteractiveWithUser.GetIntArray();

            Array.Sort(firstArray);

            int length = firstArray.Length;

            Console.WriteLine("Najmniejsza liczba to " + firstArray[0]);
            Console.WriteLine("Największa liczba to " + firstArray[length - 1]);

            Console.ReadLine();
        }
    }
}
