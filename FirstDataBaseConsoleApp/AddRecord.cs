using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDataBaseConsoleApp
{
    public static class AddRecord
    {
        public static (string name, string lastName) AddRecordMethod()
        {
            Console.Clear();

            string Name = "";
            string LastName = "";

            while (!string.IsNullOrWhiteSpace(Name))
            {
                Console.Clear();
                Console.WriteLine("Podaj imie: ");
                Name = Console.ReadLine();
            }

            while (!string.IsNullOrWhiteSpace(LastName))
            {
                Console.Clear();
                Console.WriteLine("Podaj nazwisko: ");
                LastName = Console.ReadLine();
            }

            return (Name, LastName);
        }
    }
}
