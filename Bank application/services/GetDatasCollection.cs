using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_application.services
{
    static class GetDatasCollection
    {
        public static List<UserData> Method(MainWindow mainWindow)
        {
            List<UserData> userDatas = new List<UserData>();

            foreach (var item in mainWindow.db.UserDatas)
            {
                UserData temp = new UserData();

                temp.AccountNumber = item.AccountNumber;
                temp.Password = item.Password;
                temp.Amount = item.Amount;
                temp.IsAdmin = item.IsAdmin;

                userDatas.Add(temp);
            }

            return userDatas;
        }
    }
}
