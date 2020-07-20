using System;

namespace spoj.com_PRIME_T
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Write("Podaj liczbę i sprawdź czy jest liczbą pierwszą: ");

                string testInput = Console.ReadLine();
                int liczba = int.Parse(testInput);

                Console.Clear();

                if (pierwsza(liczba) == true)
                {
                    Console.Write("To liczba pierwsza \n");
                }
                else
                {
                    Console.Write("To nie liczba pierwsza \n");
                }



            }

        }

        static bool pierwsza(int number)
        {
            if (number < 2)
            { return false; }

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
