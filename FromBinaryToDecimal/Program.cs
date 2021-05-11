using FromBinaryToDecimal.engines;
using FromDecimalToBinary.engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromBinaryToDecimal
{
    class Program
    {

        static void Main(string[] args)
        {
            for(; ; )
            {
                Console.WriteLine("Podaj liczbę do przekonwertowania");

                string s = Console.ReadLine();


                if (validate.Validate(s) == true)
                {
                    Console.WriteLine(convert.Method(s).ToString());
                }
                else
                {
                    Console.WriteLine("Podano nie właściwy ciąg znaków");
                }

            }

        }
    }
}
