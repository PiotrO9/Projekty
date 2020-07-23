using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = InteractiveWithUser.GetIntArray();

            List<int> firstList = new List<int>();

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstList.Add(firstArray[i]);
            }

            int inputIndex = InteractiveWithUser.GetIntFromUser("Wprowadź Index ");

            Console.WriteLine("Przed usunięciem ");
            Console.WriteLine("\n");

            for (int i = 0; i < firstList.Count; i++)
            {
                Console.Write(firstList[i] + " ");
            }

            firstList.RemoveAt(inputIndex);

            Console.WriteLine("Po usunięciu ");
            Console.WriteLine("\n");

            for (int i = 0; i < firstList.Count; i++)
            {
                Console.Write(firstList[i] + " ");
            }

            Console.ReadLine();

        }
    }
}
