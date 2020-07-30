using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array28
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] firstMatrix = Matrix.generateMatrix();
            firstMatrix = Matrix.fillingMatrix(firstMatrix);

            int size = firstMatrix.GetLength(0);

            int[] ResultsOfMul = new int[6];

            ResultsOfMul[0] = firstMatrix[0, 0] * firstMatrix[1, 1] * firstMatrix[2, 2];
            ResultsOfMul[1] = firstMatrix[0, 1] * firstMatrix[1, 2] * firstMatrix[2, 0];
            ResultsOfMul[2] = firstMatrix[0, 2] * firstMatrix[1, 0] * firstMatrix[2, 1];
            ResultsOfMul[3] = firstMatrix[0, 2] * firstMatrix[1, 1] * firstMatrix[2, 0];
            ResultsOfMul[4] = firstMatrix[0, 0] * firstMatrix[1, 2] * firstMatrix[2, 1];
            ResultsOfMul[5] = firstMatrix[0, 1] * firstMatrix[1, 0] * firstMatrix[2, 2];

            int determinant = ResultsOfMul[0] + ResultsOfMul[1] + ResultsOfMul[2] - ResultsOfMul[3] - ResultsOfMul[4] - ResultsOfMul[5];

            Matrix.printingMatrix(firstMatrix);

            Console.WriteLine("Wyznacznik wynosi: " + determinant);

            Console.Read();
        }
    }
}
