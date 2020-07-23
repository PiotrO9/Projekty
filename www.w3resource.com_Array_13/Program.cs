using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array_13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = new List<int>();

            int[] firstArray = InteractiveWithUser.GetIntArray();

            firstArray = Sorting.sortingByAscending(firstArray);

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstList.Add(firstArray[i]);
            }

            int insertedNumber = InteractiveWithUser.GetIntFromUser();
            int numberOfIndex = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (insertedNumber >= firstArray[firstArray.Length - 1])
                {
                    numberOfIndex = firstArray.Length;
                    break;
                }
                else if (insertedNumber > firstArray[i])
                {
                    continue;
                }
                else if (insertedNumber < firstArray[0])
                {
                    numberOfIndex = 0;
                    break;
                }
                else
                {
                    numberOfIndex = i;
                }
            }

            firstList.Insert(numberOfIndex, insertedNumber);

            Console.WriteLine("\n");

            Console.WriteLine("Oto nowy ciąg ");

            for (int i = 0; i < firstList.Count; i++)
            {
                Console.Write(firstList[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
