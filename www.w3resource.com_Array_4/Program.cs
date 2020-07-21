using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            int[] array1 = new int[loops];

            if (loops == 1)
            {
                Console.WriteLine("Wpisz 1 wartość:");
            }
            else
            {
                Console.WriteLine("Wpisz " + loops + " wartości:");
            }

            for (int i = 0; i < loops; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            int[] array2 = new int[loops];

            //Kopiowanie wartości

            for (int i = 0; i < loops; i++)
            {
                array2[i] = array2[1];
            }

            Console.WriteLine("Oto wartości 1 tablicy");

            printer(array1, loops);

            Console.WriteLine("Oto wartości 2 tablicy");

            printer(array2, loops);

            Console.ReadLine();
        }

        static void printer(int[] a, int loops2)
        {
            for (int i = 0; i < loops2; i++)
            {
                Console.WriteLine(a[i]);
            }

        }
    }
}
