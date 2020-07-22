using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayFromUser = InteractiveWithUser.GetIntArray();

            int lengthOfArrayFromUser = arrayFromUser.Length;

            int[] amountOfNumbersInArray = new int[lengthOfArrayFromUser];

            for (int i = 0; i < lengthOfArrayFromUser; i++)
            {
                amountOfNumbersInArray[i] += 1;
            }

            for (int i = 0; i < lengthOfArrayFromUser; i++)
            {
                for (int j = 0; j < lengthOfArrayFromUser; j++)
                {
                    if (i == j)
                        continue;
                    else if (arrayFromUser[i] == arrayFromUser[j] && amountOfNumbersInArray[i] > 1)
                    {
                        amountOfNumbersInArray[i]++;
                    }
                    else if (arrayFromUser[i] == arrayFromUser[j])
                    {
                        amountOfNumbersInArray[i]++;
                    }
                }
            }

            int[] secoundArrayFromUser = new int[lengthOfArrayFromUser];

            //Przypisanie do 2 tablicy

            for (int i = 0; i < lengthOfArrayFromUser; i++)
            {
                secoundArrayFromUser[i] = arrayFromUser[i];
            }

            Array.Sort(secoundArrayFromUser);

            for (int i = 0; i < lengthOfArrayFromUser; i++)
            {
                arrayFromUser[i] = 0;
            }


            for (int i = 0; i < lengthOfArrayFromUser; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (secoundArrayFromUser[i] == secoundArrayFromUser[j])
                    {
                        continue;
                    }
                    else
                        Console.WriteLine(secoundArrayFromUser[i] + " wystąpiło " + amountOfNumbersInArray[i] + " razy");
                }
            }

            Console.ReadLine();
        }
    }
}
