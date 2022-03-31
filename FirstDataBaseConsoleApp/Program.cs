using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDataBaseConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBaseInfo dataBaseInfo = new DataBaseInfo();

            string query = "INSERT INTO `Użytkownicy`(`ID`, `Imie`, `Nazwisko`, `Wiek`) VALUES('1,Jan,Kowalski,23')";

            try
            {
                dataBaseInfo.con.Open();

                Console.WriteLine("Połączono z bazą danych");

                MySqlCommand cmd = new MySqlCommand(query,dataBaseInfo.con);
                int value = cmd.ExecuteNonQuery();

                dataBaseInfo.con.Close();
            }
            catch(Exception ex)
            {
                Console.Write(ex.ToString());
            }

            

            Console.ReadKey();
        }
    }
}
