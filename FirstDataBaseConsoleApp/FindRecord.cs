using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDataBaseConsoleApp
{
    public static class FindRecord
    {
        public static string FindRecordMethod()
        {
            Console.Clear();

            string LastName = "";
            while(string.IsNullOrWhiteSpace(LastName))
            {
                Console.WriteLine("Podaj naziwisko szukanego rekordu: ");
                LastName = Console.ReadLine();
            }

            return LastName;
        }
    }
}
