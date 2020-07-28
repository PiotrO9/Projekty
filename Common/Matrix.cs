using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class Matrix
    {
        public static int[,] generateMatrix(string message = "Podaj wymiar: ")
        {
            Console.WriteLine(message);
            int firstSize;
            int secoundSize;

            int[,] mainArray;

            while (!int.TryParse(Console.ReadLine(), out firstSize))
            {
                Console.WriteLine("Wprowadzony ciąg nie jest liczbą");
            }

            while (!int.TryParse(Console.ReadLine(), out secoundSize))
            {
                Console.WriteLine("Wprowadzony ciąg nie jest liczbą");
            }

            if (firstSize > 0 && secoundSize > 0)
            {
                mainArray = new int[firstSize, secoundSize];
            }
            else
            {
                mainArray = new int[0, 0];
                Console.WriteLine("Tablica zawiera nieprawidłowy rozmiar, domyślnie utworzono 0,0");
            }

            return mainArray;
        }

        public static int[,] fillingMatrix(int[,] matrixToFill)
        {
            int size = matrixToFill.Length;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrixToFill[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return matrixToFill;
        }

    }
}
