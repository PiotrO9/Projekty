using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] firstMatrix = Matrix.generateMatrix();
            firstMatrix = Matrix.fillingMatrix(firstMatrix);

            int size = firstMatrix.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i > j)
                    {
                        firstMatrix[i, j] = 0;
                    }
                }
            }

            Matrix.printingMatrix(firstMatrix);

            Console.Read();
        }
    }
}
