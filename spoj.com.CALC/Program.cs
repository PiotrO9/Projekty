using System;

namespace spoj.com.CALC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            var userInputText = Console.ReadLine();

            int convertedNumber;
            int mnoznikOutput;

            if (TryParseUserDates(userInputText, out convertedNumber, "Użytkwnik nie wprowadził liczby") == false)
                return;

            string mnoznikInput = Console.ReadLine();

            if (TryParseUserDates(mnoznikInput, out mnoznikOutput, "Użytkwnik nie wprowadził poprawnego mnożnika") == false)
                return;

            Console.WriteLine(convertedNumber * mnoznikOutput);
            Console.ReadLine();
        }

        private static bool TryParseUserDates(string userText, out int userNumber, string userComunicate)
        {
            if (!int.TryParse(userText, out userNumber))
            {
                Console.WriteLine(userComunicate);
                return false;
            }
            return true;
        }
    }
}
