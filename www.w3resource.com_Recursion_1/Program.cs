using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Recursion_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            Recurcion(1, temp);
            Console.Read();
        }

        static int Recurcion(int s, int n)
        {
            if (n < 1)
            {
                return s;
            }
            n--;
            Console.Write(s + " ");
            return Recurcion(s + 1, n);
        }
    }
}
