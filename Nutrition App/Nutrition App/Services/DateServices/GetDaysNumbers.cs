using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrition_App.Services
{
    public static class GetDaysNumbers
    {
        public static string[] GetDaysNumbersMethod()
        {
            string[] result = new string[5];

            DateTime dateTime;
            int iterator = 0;


            for (int i = -2; i < 3; i++)
            {
                dateTime = DateTime.Today.AddDays(i);

                result[iterator] = dateTime.ToString("dd");
                iterator++;
            }

            return result;
        }
    }
}
