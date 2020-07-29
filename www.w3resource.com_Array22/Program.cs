using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] firstMatrix = Matrix.generateMatrix();

            Console.WriteLine("Wprowadź dane: ");

            firstMatrix = Matrix.fillingMatrix(firstMatrix);

            int[,] secoundMatrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];

            for (int i = 0; i < secoundMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < secoundMatrix.GetLength(1); j++)
                {
                    secoundMatrix[i, j] = firstMatrix[j, i];
                }
            }

            Console.WriteLine("Wypisywanie macierzy");

            for (int i = 0; i < secoundMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < secoundMatrix.GetLength(0); j++)
                {
                    Console.Write(secoundMatrix[i, j]);
                }
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
