using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayFromUser = InteractiveWithUser.GetIntArray();

            int NumberOfLoops = arrayFromUser.Length;

            if (NumberOfLoops <= 0)
            {
                Console.WriteLine("Brak tablicy od użytkownika");
            }
            else
            {
                bool[] differentValuesOfArray = new bool[NumberOfLoops];
                for (int i = 0; i < NumberOfLoops; i++)
                {
                    if (differentValuesOfArray[i] == true)
                    {
                        continue;
                    }
                    else
                    {
                        for (int j = 0; j < NumberOfLoops; j++)
                        {
                            if (i == j)
                                continue;
                            if (arrayFromUser[i] == arrayFromUser[j])
                            {
                                differentValuesOfArray[i] = true;
                                differentValuesOfArray[j] = true;
                            }
                        }
                    }
                }

                Console.WriteLine("----------------------");

                for (int i = 0; i < NumberOfLoops; i++)
                {
                    if (differentValuesOfArray[i] == false)
                    {
                        Console.WriteLine(arrayFromUser[i]);
                    }
                }

            }
            Console.ReadLine();
        }


    }
}
