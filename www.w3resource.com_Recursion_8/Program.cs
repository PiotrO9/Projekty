using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.w3resource.com_Recursion_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wyraz, żeby sprawdzić czy jest palindromem: ");
            string word = Console.ReadLine();

            if (PalindromeCheck(word) == true)
            {
                Console.WriteLine("Podany wyraz jest palindromem");
            }
            else
            {
                Console.WriteLine("Podany wyraz nie jest palindromem");
            }

            Console.ReadLine();
        }

        static bool PalindromeCheck(string s)
        {
            if (s.Length <= 1)
            {
                return true;
            }
            else
            {
                if (s[0] != s[s.Length - 1])
                {
                    return false;
                }
                else
                {
                    return PalindromeCheck(s.Substring(1, s.Length - 2));
                }
            }
        }
    }
}
