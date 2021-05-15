using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczby");

            Console.WriteLine("Podaj a: ");
           double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c: ");
            double c = double.Parse(Console.ReadLine());

            List<double> result = quadratic_function.Method(a,b,c);

            if(result.Count == 0)
            {
                Console.WriteLine("Nie ma rozwiązań");
            }
            else
            {
                foreach (var solution in result)
                {
                    Console.WriteLine(Math.Round(solution,2).ToString());
                }
            }

            Console.ReadKey();
        }
    }
}
