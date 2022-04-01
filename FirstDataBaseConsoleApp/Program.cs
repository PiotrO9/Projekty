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
            while (true)
            {
                DisplayMenu.DisplayMenuMethod();

                int choice = int.TryParse(Console.ReadLine(), out choice) ? choice : -1;

                DataBaseInfo dataBaseInfo = new DataBaseInfo();

                switch (choice)
                {
                    case 1:
                        {
                            ExecuteDBaction.ExecuteAddRecordActionMethod(dataBaseInfo);

                            break;
                        }
                    case 2:
                        {

                            ExecuteDBaction.ExecuteDbFindActionWithResultMethod(dataBaseInfo, $"SELECT * FROM `Users` WHERE LastName = '{FindRecord.FindRecordMethod()}'");

                            break;
                        }
                    case 3:
                        {
                            ExecuteDBaction.ExecuteDbDeleteActionMethod(dataBaseInfo);

                            break;
                        }
                    default:
                        break;
                }

                dataBaseInfo.con.Close();

                Console.ReadKey();
            }
        }
    }
}
