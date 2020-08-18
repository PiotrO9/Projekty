using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Function_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibb(number));
            Console.ReadLine();
        }

        static int Fibb(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            else
            {
                return Fibb(n - 1) + Fibb(n - 2);
            }
        }
    }
}
