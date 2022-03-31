using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDataBaseConsoleApp
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            DisplayMenu.DisplayMenuMethod();

            int choice = int.TryParse(Console.ReadLine(), out choice) ? choice : 1;
            string query = "";

            DataBaseInfo dataBaseInfo = new DataBaseInfo();

            switch (choice)
            {
                case 1:
                    {
                        (string,string) RecordTuple = AddRecord.AddRecordMethod();
                        ExecuteDBaction.ExecuteDBactionMethod(dataBaseInfo, $"INSERT INTO `Users`(`Name`, `LastName`) VALUES ({RecordTuple.Item1},{RecordTuple.Item1})");

                        break;
                    }
                case 2:
                    {

                        ExecuteDBaction.ExecuteDBactionWithResultMethod(dataBaseInfo, $"SELECT * FROM `Users` WHERE LastName = '{FindRecord.FindRecordMethod()}'");

                        break;
                    }
                default:
                    break;
            }

            dataBaseInfo.con.Close();


            //DataBaseInfo dataBaseInfo = new DataBaseInfo();

            //string query = "INSERT INTO `Users`(`Name`, `LastName`) VALUES ('Jan','Kowalski')";

            //try
            //{
            //    dataBaseInfo.con.Open();

            //    Console.WriteLine("Połączono z bazą danych");

            //    MySqlCommand cmd = new MySqlCommand(query,dataBaseInfo.con);
            //    int value = cmd.ExecuteNonQuery();

            //    dataBaseInfo.con.Close();
            //}
            //catch(Exception ex)
            //{
            //    Console.Write(ex.ToString());
            //}

            Console.ReadKey();
        }
    }
}
