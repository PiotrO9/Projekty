using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Function_5
{
    class Program
    {
        public static int counting(int[] mainArray)
        {
            int sum = 0;
            for (int i = 0; i < mainArray.Length; i++)
            {
                sum += mainArray[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int size;

            Console.WriteLine("Wprowadź liczbę elementów w tabeli");

            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Wprowadzona liczba jest nieprawidłowa, wprowadź ponownie");
            }


            int[] firstArray = new int[size];

            Console.WriteLine("Wprowadzanie elementów do tablicy");

            for (int i = 0; i < size; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            int result = counting(firstArray);

            Console.WriteLine("Suma elementów w tablicy: " + result);
            Console.ReadLine();

        }
    }
}
