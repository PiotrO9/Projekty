using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrition_App.Services.FileServices
{
    public static class CombineTodayFileName
    {
        public static string CombineTodayFileNameMethod()
        {
            string result = "";

            DateTime dateTime =  DateTime.Today;

            int dayNumber = dateTime.Day;

            if(dayNumber < 10)
            {
                result += "0" + dayNumber.ToString();
            }
            else
            {
                result += dayNumber.ToString();
            }

            int monthNumber = dateTime.Month;

            if(monthNumber < 10)
            {
                result += "0" + monthNumber.ToString();
            }
            else
            {
                result += monthNumber.ToString();
            }

            result += dateTime.Year.ToString() + ".txt";

            return result;
        }
    }
}
