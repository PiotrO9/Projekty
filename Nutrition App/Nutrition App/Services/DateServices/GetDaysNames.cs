using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrition_App.Services.DateServices
{
    public static class GetDaysNames
    {
        public static string[] GetDaysNamesMethod()//Today
        {
            string[] result = new string[5];

            DateTime dateTime;
            int iterator = 0;

            for (int i = -2; i < 3; i++)
            {
                dateTime = DateTime.Today.AddDays(i);

                result[iterator] = dateTime.ToString("ddd");
                iterator++;
            }

            return result;
        }
        public static string[] GetDaysNamesMethod(int difference)//Today
        {
            string[] result = new string[5];

            DateTime dateTime;
            int iterator = 0;

            for (int i = -2; i < 3; i++)
            {
                dateTime = DateTime.Today.AddDays(i + difference);

                result[iterator] = dateTime.ToString("ddd");
                iterator++;
            }

            return result;
        }
    }
}
