using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array30
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checking = true;

            int[,] firstMartix = Matrix.generateMatrix();
            int[,] secoundMartix = Matrix.generateMatrix();

            firstMartix = Matrix.fillingMatrix(firstMartix, "Wypełnianie 1 macierzy");
            secoundMartix = Matrix.fillingMatrix(secoundMartix, "Wypełnianie 2 macierzy");

            if (firstMartix.Length == secoundMartix.Length)
            {
                for (int i = 0; i < firstMartix.GetLength(0); i++)
                {
                    for (int j = 0; j < firstMartix.GetLength(0); j++)
                    {
                        if (firstMartix[i, j] != secoundMartix[i, j])
                        {
                            checking = false;
                        }
                    }
                }

                Console.WriteLine("Macierze można porównać: ");

                if (checking == true)
                {
                    Console.WriteLine("Macierze są równe");
                }
                else
                {
                    Console.WriteLine("Macierze nie są równe");
                }

            }
            else
            {
                Console.WriteLine("Macierzy nie można porównać");
            }

            Console.ReadLine();
        }
    }
}
