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

                Test firstChar = Test.Plus;

                string znak = wordlist[0];

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

               Console.WriteLine(Calculate(number1, number2,firstChar));
            }
         
            int Calculate(int firstNumber, int secoundNumber, Test wyliczeniowy)
            {
                switch (wyliczeniowy)
                {
                    case Test.Plus:
                        return firstNumber + secoundNumber;
                    case Test.Minus:
                        return firstNumber - secoundNumber;
                    case Test.Mnozenie:
                        return firstNumber * secoundNumber;
                    case Test.Dzielenie:
                        {
                            if (secoundNumber == 0)
                            {
                                Console.WriteLine("Dzielenie przez 0 niemożliwe!");
                                break;
                            }
                        return firstNumber / secoundNumber;
                        }
                    case Test.Reszta:
                        return firstNumber%secoundNumber;
                    default:
                        return 0;
                }

                return 0;
            }
        
        }   
    } 

}
