using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] firstMatrix = Matrix.generateMatrix();

            int[,] secoundMatrix = Matrix.generateMatrix();

            Console.WriteLine("Wypełnianie 1 macierzy");

            firstMatrix = Matrix.fillingMatrix(firstMatrix);

            Console.WriteLine("Wypełnianie 2 macierzy");

            secoundMatrix = Matrix.fillingMatrix(secoundMatrix);

            int[,] thirdMatrix = Matrix.generateMatrix();

            int sizeOfThirdMatrix = thirdMatrix.Length;

            for (int i = 0; i < sizeOfThirdMatrix; i++)
            {
                for (int j = 0; j < sizeOfThirdMatrix; j++)
                {
                    thirdMatrix[i, j] = firstMatrix[i, j] * secoundMatrix[j, i];
                }
            }

            Console.WriteLine("Wartości 3 macierzy");

            for (int i = 0; i < sizeOfThirdMatrix; i++)
            {
                for (int j = 0; j < sizeOfThirdMatrix; j++)
                {
                    Console.Write(thirdMatrix[i, j] + " ");
                }
                Console.Write("\n");
            }

            Console.ReadLine();

        }
    }
}
