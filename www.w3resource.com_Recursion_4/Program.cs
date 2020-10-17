using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Recursion_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciąg");

            int inputText = int.Parse(Console.ReadLine());

            Display(inputText);

            Console.Read();
        }

        static void Display(int temp)
        {
            if (temp < 10)
            {
                Console.Write(temp + " ");
                return;
            }

            Display(temp / 10);
            Console.Write(temp % 10 + " ");
        }
    }
}
