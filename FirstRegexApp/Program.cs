using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FirstRegexApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string RegularExpresion = @"^[A-Za-zżźćńółęąśŻŹĆĄŚĘŁÓŃ]+\.?[A-Za-zżźćńółęąśŻŹĆĄŚĘŁÓŃ0-9]+@[A-Za-zżźćńółęąśŻŹĆĄŚĘŁÓŃ]+\.[A-Za-zżźćńółęąśŻŹĆĄŚĘŁÓŃ]{2,3}$";
            Regex regex = new Regex(RegularExpresion);

            Console.WriteLine("Podaj maila do sprawdzania: ");
            string inputMail = Console.ReadLine();

            if (regex.IsMatch(inputMail))
                Console.WriteLine("Poprawny e-mail");
            else
                Console.WriteLine("Niepoprawny e-mail");

            Console.ReadLine();
        }
    }
}
