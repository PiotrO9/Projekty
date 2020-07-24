using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    class Matrix
    {
        int[,] generateMatrix()
        {
            Console.WriteLine("Podaj 1 wymiar: ");
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

    }
}
