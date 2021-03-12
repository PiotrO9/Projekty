using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 12;

            Console.WriteLine(number);
            Console.WriteLine(number.GetType());

            dynamic variable = 12;

            Console.WriteLine(variable);
            Console.WriteLine(variable.GetType());

            variable = "234";

            Console.WriteLine(variable);
            Console.WriteLine(variable.GetType());

            Console.ReadLine();
        }
    }
}
