using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array23
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            int[,] firstMatrix = Matrix.generateMatrix();

            firstMatrix = Matrix.fillingMatrix(firstMatrix);

            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < firstMatrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += firstMatrix[i, j];
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < firstMatrix.GetLength(1); j++)
                {
                    Console.Write(firstMatrix[i, j]);
                }
                Console.Write("\n");
            }

            Console.WriteLine("Suma prawych przekątnych macierzy wynosi: " + sum);
            Console.ReadLine();
        }
    }
}
