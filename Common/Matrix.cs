using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class Matrix
    {
        public static int[,] generateMatrix(string message = "Podaj wymiary: ")
        {
            Console.WriteLine(message);
            int size;

            int[,] mainArray;

            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Wprowadzony ciąg nie jest liczbą");
            }

            if (size > 0)
            {
                mainArray = new int[size, size];
            }
            else
            {
                mainArray = new int[0, 0];
                Console.WriteLine("Tablica zawiera nieprawidłowy rozmiar, domyślnie utworzono macierz o rozmiarze 0,0");
            }

            return mainArray;
        }

        public static int[,] fillingMatrix(int[,] matrixToFill)
        {
            int size = matrixToFill.GetLength(0);

            Console.WriteLine("Wypełnianie macierzy");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrixToFill[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return matrixToFill;
        }

        public static void printingMatrix(int[,] matrixToPrint)
        {
            int size = matrixToPrint.GetLength(0);

            Console.WriteLine("Wyświetlanie macierzy");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrixToPrint[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

    }
}
