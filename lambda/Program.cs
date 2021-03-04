using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> cube = (x, y) =>
            {
                int temp = x * y;

                return temp * x;
            };
            Console.WriteLine(cube(3, 5));

            List<int> numbers = new List<int> { 1, 2, 4, 6, 23 };

            Console.ReadLine();
        }

        //static bool TestCor(int khkhkh)
        //{
        //    return false;

        //}

        //static IEnumerable<int> where(Func<int, bool> func)
        //{
        //    var bollstate = func?.Invoke(7);
        //    func += global => false;
        //}
    }
}
