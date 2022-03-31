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
        public static void ExecuteDBactionMethod(DataBaseInfo dataBaseInfo, string query)
        {
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
        }

        public static void ExecuteDBactionWithResultMethod(DataBaseInfo dataBaseInfo, string query)
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
        }
    }
}
