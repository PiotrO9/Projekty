using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrition_App.Services.DateServices
{
   public static class CombineDateInformation
    {
        public static string[] CombineDateInformationMethod()
        {
            string[] result = new string[5];

            string[] DaysNumbers = GetDaysNumbers.GetDaysNumbersMethod();
            string[] DaysNames = GetDaysNames.GetDaysNamesMethod();
            const string LineEnd = "    ";

            for (int i = 0; i < 5; i++)
            {
                string tempDayName = DaysNames[i];

                tempDayName = tempDayName.Remove(tempDayName.Length - 1);

                if (tempDayName.Length > 3)
                {
                   tempDayName = tempDayName.Substring(0, 3);
                }

                result[i] = DaysNumbers[i] + " " + LineEnd + tempDayName.ToUpper();
            }

            return result;
        }

        public static string[] CombineDateInformationMethod(int difference)
        {
            string[] result = new string[5];

            string[] DaysNumbers = GetDaysNumbers.GetDaysNumbersMethod(difference);
            string[] DaysNames = GetDaysNames.GetDaysNamesMethod(difference);
            const string LineEnd = "    ";

            for (int i = 0; i < 5; i++)
            {
                string tempDayName = DaysNames[i];

                tempDayName = tempDayName.Remove(tempDayName.Length - 1);

                if (tempDayName.Length > 3)
                {
                    tempDayName = tempDayName.Substring(0, 3);
                }

                result[i] = DaysNumbers[i] + " " + LineEnd + tempDayName.ToUpper();
            }

            return result;
        }
    }
}
