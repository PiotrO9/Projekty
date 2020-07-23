using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = InteractiveWithUser.GetIntArray();

            int evenElements = 0;
            int oddElements = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    evenElements++;
                }
                else
                {
                    oddElements++;
                }
            }

            int[] evenArray = new int[evenElements];
            int[] oddArray = new int[oddElements];

            int j = 0;
            int k = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    evenArray[j] = myArray[i];
                    j++;
                }
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 != 0)
                {
                    oddArray[k] = myArray[i];
                    k++;
                }
            }

            Console.Write("Parzyste liczby to: ");

            for (int i = 0; i < evenArray.Length; i++)
            {
                Console.Write(evenArray[i] + " ");
            }

            Console.Write("\n");
            Console.Write("Nieparzysteliczby to: ");

            for (int i = 0; i < oddArray.Length; i++)
            {
                Console.Write(oddArray[i] + " ");
            }

            Console.ReadLine();

        }
    }
}
