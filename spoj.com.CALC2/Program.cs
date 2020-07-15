using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
