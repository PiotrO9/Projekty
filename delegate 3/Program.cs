using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_3
{
    class Program
    {
        delegate void Delegate1();

        delegate int Delegate2();

        static void Main(string[] args)
        {
            Delegate1 del = text1;
            del += text2;
            del += text3;
            del -= text2;

            del();

            Delegate2 del2 = number1;

            int value = del2();

            Console.WriteLine(value.ToString());

            del2 += number2;
            value = del2();

            Console.WriteLine(value.ToString());

            Console.ReadLine();
        }

        static void text1()
        {
            Console.WriteLine("text 1");
        }

        static void text2()
        {
            Console.WriteLine("text 2");
        }

        static void text3()
        {
            Console.WriteLine("text 3");
        }

        static int number1()
        {
            return 7;
        }
        static int number2()
        {
            return 3;
        }
    }
}
