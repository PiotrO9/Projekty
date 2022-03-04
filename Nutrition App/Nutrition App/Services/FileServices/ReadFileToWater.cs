using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Nutrition_App.Services.FileServices
{
    public static class ReadFileToWater
    {
        public static string ReadFileToWaterMethod(int difference)
        {
            string dayNameToReadFrom = "w" + CombineDifferenceFileName.CombineDifferenceFileNameMethod(difference);

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)) + "/water/" + dayNameToReadFrom;

            string result = "";

            try
            {
                using (var reader = new StreamReader(path))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch
            {
                result = "0";
            }

            return result;
        }
    }
}
