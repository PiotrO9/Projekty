using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] firstMartix = Matrix.generateMatrix();
            firstMartix = Matrix.fillingMatrix(firstMartix);

            bool checking = true;

            int size = firstMartix.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i == j && firstMartix[i, j] != 1) || (i != j && firstMartix[i, j] != 0))
                    {
                        checking = false;
                    }
                }
            }

            if (checking == true)
            {
                Console.WriteLine("Macierz jest macierzą tożsamości");
            }
            else
            {
                Console.WriteLine("Macierz nie jest macierzą tożsamości");
            }

            Console.ReadLine();

        }
    }
}
