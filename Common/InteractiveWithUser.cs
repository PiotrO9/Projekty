using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class InteractiveWithUser
    {
        public static int GetIntFromUser()
        {
            Console.WriteLine("Wprowadź liczbę");
            int loops;

            while (!int.TryParse(Console.ReadLine(), out loops))
            {
                Console.WriteLine("Wprowadzony ciąg nie jest liczbą");
            }

            return loops;
        }

        public static int[] GetIntArray()
        {
            Console.WriteLine("Tworzenie nowej tablicy");
            int loops = GetIntFromUser();

            if (loops <= 0)
            {
                Console.WriteLine("Wprowadzono niepoprawną wielkość talbicy");
                return new int[0];
            }

            int[] inputArray = new int[loops];

            for (int i = 0; i < loops; i++)
            {
                inputArray[i] = GetIntFromUser();
            }

            return inputArray;
        }
    }
}
