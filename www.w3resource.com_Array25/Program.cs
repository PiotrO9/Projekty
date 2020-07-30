using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] firstMatrix = Matrix.generateMatrix();
            firstMatrix = Matrix.fillingMatrix(firstMatrix);

            int sizeOfMatrix = firstMatrix.GetLength(0);

            int[] amountOfHorizontal = new int[sizeOfMatrix];
            int[] amountOfVertical = new int[sizeOfMatrix];

            for (int i = 0; i < sizeOfMatrix; i++)
            {
                for (int j = 0; j < sizeOfMatrix; j++)
                {
                    amountOfHorizontal[i] += firstMatrix[i, j];
                }
            }

            for (int i = 0; i < sizeOfMatrix; i++)
            {
                for (int j = 0; j < sizeOfMatrix; j++)
                {
                    amountOfVertical[i] += firstMatrix[j, i];
                }
            }

            //Wypisanie

            for (int i = 0; i < sizeOfMatrix; i++)
            {
                for (int j = 0; j < sizeOfMatrix; j++)
                {
                    Console.Write(firstMatrix[i, j] + " ");
                }
                Console.Write(amountOfHorizontal[i]);
                Console.Write("\n");
            }

            for (int i = 0; i < sizeOfMatrix; i++)
            {
                Console.Write(amountOfVertical[i] + " ");
            }

            Console.Write("\n");

            Console.ReadLine();

        }
    }
}
