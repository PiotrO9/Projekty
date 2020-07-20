using System;

namespace spoj.com.CALC2
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInputText = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userInputText))
            {
                Console.WriteLine("Pętla zaczyna się");
                userInputText = Console.ReadLine();
            }
            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
