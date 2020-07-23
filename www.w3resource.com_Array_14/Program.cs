using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = InteractiveWithUser.GetIntArray();

            List<int> firstList = new List<int>(firstArray.Length + 1);

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstList.Add(firstArray[i]);
            }

            firstArray = Sorting.sortingByAscending(firstArray);

            int inputValue = InteractiveWithUser.GetIntFromUser();

            int inputIndex = InteractiveWithUser.GetIntFromUser("Wprowadź index");

            Console.WriteLine("Przed dodaniem wartości");
            Console.WriteLine("\n");

            for (int i = 0; i < firstList.Count; i++)
            {
                Console.Write(firstList[i] + " ");
            }

            firstList.Insert(inputIndex, inputValue);

            Console.WriteLine("\n");
            Console.WriteLine("Po dodaniu wartości");
            Console.WriteLine("\n");

            for (int i = 0; i < firstList.Count; i++)
            {
                Console.Write(firstList[i] + " ");
            }

            Console.ReadLine();

        }
    }
}