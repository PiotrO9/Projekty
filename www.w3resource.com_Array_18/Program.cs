using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] firstArray = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Podaj liczbę dla [" + i + "][" + j + "]");
                    firstArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(firstArray[i, j]);
                }
                Console.Write("\n");
            }

            Console.ReadLine();

        }
    }
}
