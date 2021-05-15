using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euklides_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 1 liczbeę: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj 2 liczbeę: ");
            int n2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Największy wspólny dzielnik to: " + NWD.Method(n1,n2));
            Console.ReadLine();

        }
    }
}
