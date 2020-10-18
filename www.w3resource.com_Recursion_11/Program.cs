using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Recursion_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 2 liczby: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int hcf = gcd(n1, n2);

            Console.WriteLine("GCD wynosi: " + hcf);
            Console.WriteLine("LCM wynosi: " + ((n1 * n2) / hcf));


            Console.ReadLine();
        }

        static int gcd(int n1, int n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return gcd(n2, n1 % n2);
            }
        }
    }
}
