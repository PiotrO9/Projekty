using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrition_App.Services.DateServices
{
    public static class CalculateDateDifference
    {
        public static int CalculateDateDifferenceMethod(DateTime firstDay, DateTime secondDay)
        {
            DateTime d1 = firstDay;
            DateTime d2 = secondDay;

            return int.Parse(((d1 - d2).TotalDays).ToString()) * -1;
        }
    }
}
