using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Array20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar macierzy kwadratowej: ");

            int sizeOfMatrice = int.Parse(Console.ReadLine());

            int[,] firstArray = new int[sizeOfMatrice, sizeOfMatrice];

            int[,] secoundArray = new int[sizeOfMatrice, sizeOfMatrice];

            Console.WriteLine("Wprowadź dane dla pierwszej tabeli: ");

            for (int i = 0; i < sizeOfMatrice; i++)
            {
                for (int j = 0; j < sizeOfMatrice; j++)
                {
                    Console.WriteLine("Podaj liczbę dla [" + i + "][" + j + "]");
                    firstArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Wprowadź dane dla drugiej tabeli: ");

            for (int i = 0; i < sizeOfMatrice; i++)
            {
                for (int j = 0; j < sizeOfMatrice; j++)
                {
                    Console.WriteLine("Podaj liczbę dla [" + i + "][" + j + "]");
                    secoundArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Pierwsza macierz");

            for (int i = 0; i < sizeOfMatrice; i++)
            {
                for (int j = 0; j < sizeOfMatrice; j++)
                {
                    Console.Write(firstArray[i, j] + " ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("Druga macierz");

            for (int i = 0; i < sizeOfMatrice; i++)
            {
                for (int j = 0; j < sizeOfMatrice; j++)
                {
                    Console.Write(secoundArray[i, j] + " ");
                }
                Console.Write("\n");
            }

            int[,] thirdArray = new int[sizeOfMatrice, sizeOfMatrice];

            for (int i = 0; i < sizeOfMatrice; i++)
            {
                for (int j = 0; j < sizeOfMatrice; j++)
                {
                    thirdArray[i, j] = firstArray[i, j] - secoundArray[i, j];
                }
            }

            Console.WriteLine("Trzecia macierz");

            for (int i = 0; i < sizeOfMatrice; i++)
            {
                for (int j = 0; j < sizeOfMatrice; j++)
                {
                    Console.Write(thirdArray[i, j] + " ");
                }
                Console.Write("\n");
            }

            Console.ReadLine();

        }
    }
}
