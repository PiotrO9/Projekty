using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace spoj.com_CALC_enum
{
    class Program
    {

 enum Test{Plus,Minus,Mnozenie,Dzielenie,Reszta}
        static void Main(string[] args)
        {
            string textInput;

            for (int i = 0; i < 100; i++)
            {
                textInput = Console.ReadLine();

                string[] wordlist = textInput.Split(' ');

                int number1 = int.Parse(wordlist[1]);
                int number2 = int.Parse(wordlist[2]);

                Test firstChar;

                string znak = wordlist[0];

                string testing1;

                if(wordlist[0] == "+")
                {
                    firstChar = Test.Plus;
                }
                else if(wordlist[0] == "-")
                {
                    firstChar = Test.Minus;
                }
                else if (wordlist[0] == "*")
                {
                    firstChar = Test.Mnozenie;
                }
                else if (wordlist[0] == "/")
                {
                    firstChar = Test.Dzielenie;
                }
                else if (wordlist[0] == "%")
                {
                    firstChar = Test.Reszta;
                }
                else 
                {
                    Console.WriteLine("Źle podany pierwszy znak");
                    Console.ReadLine();
                    
                }

                switch(firstChar)
                {
                    case Test.Plus:
                        { }

                }

            }
         }   
    } 

}
