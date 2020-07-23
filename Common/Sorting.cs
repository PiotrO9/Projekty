using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class Sorting
    {
        public static int[] sortingByAscending(int[] mainArray, int number = 0)
        {
            Array.Sort(mainArray);

            if (mainArray.Length < 0)
            {
                Console.WriteLine("Nieprawidłowy rozmiar tablicy");
                return mainArray;
            }

            if (mainArray.Length == 0)
            {
                Console.WriteLine("Sortowanie tablicy nie możliwe, długość wynosi 0");
            }
            else if (number > 0)
            {

                printingArray(mainArray);
            }
            else if (number == 0)
            {
                Console.WriteLine("Sortowanie przebiegło pomyślnie");
            }

            return mainArray;
        }

        public static int[] sortingByDescending(int[] mainArray, int number = 0)
        {
            Array.Sort(mainArray);
            Array.Reverse(mainArray);

            if (mainArray.Length < 0)
            {
                Console.WriteLine("Nieprawidłowy rozmiar tablicy");
                return mainArray;
            }

            if (mainArray.Length == 0)
            {
                Console.WriteLine("Sortowanie tablicy nie możliwe, długość wynosi 0");
            }
            else if (number > 0)
            {
                printingArray(mainArray);
            }
            else if (number == 0)
            {
                Console.WriteLine("Sortowanie przebiegło pomyślnie");
            }

            return mainArray;
        }

        public static void printingArray(int[] arrayToPrint)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < arrayToPrint.Length; i++)
            {
                Console.Write(arrayToPrint[i]);
            }
        }

    }
}
