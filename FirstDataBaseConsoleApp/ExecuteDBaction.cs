using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDataBaseConsoleApp
{
    public static class ExecuteDBaction
    {
        public static void ExecuteAddRecordActionMethod(DataBaseInfo dataBaseInfo)
        {
            string Name = "";
            string LastName = "";

            while (string.IsNullOrWhiteSpace(Name))
            {
                Console.Clear();
                Console.WriteLine("Podaj imie: ");
                Name = Console.ReadLine();
            }

            while (string.IsNullOrWhiteSpace(LastName))
            {
                Console.Clear();
                Console.WriteLine("Podaj nazwisko: ");
                LastName = Console.ReadLine();
            }

            string query = $"INSERT INTO `Users`(`Name`, `LastName`) VALUES ('{Name}','{LastName}')";

            try
            {
                dataBaseInfo.con.Open();

                MySqlCommand cmd = new MySqlCommand(query, dataBaseInfo.con);
                int value = cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }

            Console.WriteLine("Dodano nowy rekord, sprawdź swoją bazę danych");
            dataBaseInfo.con.Close();
            Console.WriteLine("Naciśnij dowolny klawisz, żeby wrócić do menu");
        }

        public static void ExecuteDbFindActionWithResultMethod(DataBaseInfo dataBaseInfo, string query)
        {
            try
            {
                Console.WriteLine("Oto znalezione rekordy o podanym nazwisku");

                dataBaseInfo.con.Open();

                MySqlCommand cmd = new MySqlCommand(query, dataBaseInfo.con);
                using (var reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0) + " " + reader.GetString(1));
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            dataBaseInfo.con.Close();

            Console.WriteLine("Naciśnij dowolny klawisz, żeby wrócić do menu");
        }

        public static void ExecuteDbDeleteActionMethod(DataBaseInfo dataBaseInfo)
        {
            string Name = "";
            string LastName = "";

            while (string.IsNullOrWhiteSpace(Name))
            {
                Console.Clear();
                Console.WriteLine("Podaj imie: ");
                Name = Console.ReadLine();
            }

            while (string.IsNullOrWhiteSpace(LastName))
            {
                Console.Clear();
                Console.WriteLine("Podaj nazwisko: ");
                LastName = Console.ReadLine();
            }

            string query = $"DELETE FROM `Users` WHERE Name = '{Name}' AND LastName = '{LastName}'";

            try
            {
                dataBaseInfo.con.Open();

                MySqlCommand cmd = new MySqlCommand(query, dataBaseInfo.con);
                int value = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            Console.WriteLine("Usunięto istniejące rekordy w bazie danych");
            dataBaseInfo.con.Close();
            Console.WriteLine("Naciśnij dowolny klawisz, żeby wrócić do menu");
        }
    }
}
