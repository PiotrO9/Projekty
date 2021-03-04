using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_2
{
    delegate bool MeDelegate(int n);

    class Program
    {
        static bool EvenNumber(int n) { return n % 2 == 0; }

        static bool OddNumber(int n) { return n % 2 != 0; }

        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 5, 4, 3, 1, 5, 6, 7 };

            IEnumerable<int> result = RunNumbers(numbers, EvenNumber);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static IEnumerable<int> RunNumbers(IEnumerable<int> numbers, MeDelegate meDelegate)
        {
            foreach (var number in numbers)
            {
                if (meDelegate(number))
                    yield return number;
            }
        }
    }
}
