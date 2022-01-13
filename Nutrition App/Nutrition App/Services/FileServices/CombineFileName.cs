using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrition_App.Services.FileServices
{
    public static class CombineFileName
    {
        public static string CombineFileNameMethod(string[] Datas)
        {
            string result = "";

            DateTime dateTime = DateTime.Now;

            result += Datas[0];

            if (dateTime.Month < 10)
            {
                result += "0" + dateTime.Month;
            }

            result += dateTime.Year + ".txt";

            return result;
        }
    }
}
