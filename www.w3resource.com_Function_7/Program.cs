using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Function_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber = int.Parse(Console.ReadLine());
            Console.Write("\n");
            int SecoundNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(FirstNumber, SecoundNumber));
            Console.ReadLine();
        }

        static int Calculate(int f, int s)
        {
            if (s == 0)
            {
                return 1;
            }
            else if (s == 1)
            {
                return f;
            }
            else
            {
                int temp = f;
                for (int i = 1; i < s; i++)
                {
                    temp *= f;
                }
                return temp;
            }
        }
    }
}
