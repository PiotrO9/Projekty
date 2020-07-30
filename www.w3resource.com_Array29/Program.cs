using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array29
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] firstMatrix = Matrix.generateMatrix();
            firstMatrix = Matrix.fillingMatrix(firstMatrix);

            int size = firstMatrix.GetLength(0);
            int amountOfZero = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (firstMatrix[i, j] == 0)
                    {
                        amountOfZero++;
                    }
                }
            }

            if (amountOfZero > firstMatrix.Length / 2)
            {
                Console.WriteLine("Podana macierz jest rzadką macierzą");
            }
            else
            {
                Console.WriteLine("Podana macierz nie jest rzadką macierzą");
            }

            if (amountOfZero == 0)
            {
                Console.WriteLine("W macierzy nie ma zer");
            }
            else if (amountOfZero == 1)
            {
                Console.WriteLine("W macierzy znajduje się 1 zero");
            }
            else
            {
                Console.WriteLine("W macierzy znajduje się: " + amountOfZero + " zera");
            }

            Console.ReadLine();

        }
    }
}
