using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] firstMatrix = Matrix.generateMatrix();
            firstMatrix = Matrix.fillingMatrix(firstMatrix);

            int sum = 0;
            int tempNumber = firstMatrix.GetLength(0);

            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                tempNumber--;
                for (int j = 0; j < firstMatrix.GetLength(0); j++)
                {
                    if (j == tempNumber)
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
                for (int j = 0; j < firstMatrix.GetLength(0); j++)
                {
                    Console.Write(firstMatrix[i, j]);
                }
                Console.Write("\n");
            }

            Console.WriteLine("Wynik dodawania lewych przekątnych: " + sum);
            Console.ReadLine();
        }
    }
}
