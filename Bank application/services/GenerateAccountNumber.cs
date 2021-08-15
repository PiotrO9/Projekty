using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_application.services
{
    static class GenerateAccountNumber
    {
        public static int Method(MainWindow mainWindow)
        {
            Random rnd;
            int number;
            UserData userData;

            do
            {
                rnd = new Random();
                number = rnd.Next(1000000, 2000000);

                try
                {
                    userData = (from x in mainWindow.db.UserDatas
                                where x.AccountNumber == number
                                select x).First();
                }
                catch(Exception e)
                {
                    return number;
                }
            }
            while (userData != null);

            return number;
        }
    }
}
