using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDataBaseConsoleApp
{
    public static class DisplayMenu
    {
        public static void DisplayMenuMethod()
        {
            Console.Clear();

            Console.WriteLine("-----------");
            Console.WriteLine("Wybierz opcje");
            Console.WriteLine("1. Stwórz rekord");
            Console.WriteLine("2. Znajdź rekord");
            Console.WriteLine("3. Usuń rekord");
            Console.WriteLine("-----------");
        }
    }
}
