using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Function_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj napis: ");
            string text = Console.ReadLine();

            string test;

            int countingSpecialSigns = 0;


            for (int i = 0; i < text.Length; i++)
            {
                test = text.Substring(i, 1);

                if (test == " ")
                {
                    countingSpecialSigns++;
                }

            }
            if (countingSpecialSigns == 0)
            {
                Console.WriteLine(text + " nie zawiera spacji");
            }
            else
                Console.WriteLine(text + " zawiera " + countingSpecialSigns + " spacje");

            Console.ReadLine();

        }
    }
}
