using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Recursion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            Recursion(20, 1);
            Console.ReadLine();
        }
        static int Recursion(int n, int s)
        {
            if (n < 1)
            {
                return s;
            }
            n--;
            Console.Write((n + 1) + " ");
            return Recursion(n, s);
        }
    }
}
