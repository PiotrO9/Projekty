using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = InteractiveWithUser.GetIntArray();

            firstArray = Sorting.sortingByAscending(firstArray);

            Console.WriteLine("Druga najmniejsza liczba to " + firstArray[1]);
            Console.ReadLine();
        }
    }
}
