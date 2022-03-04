using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Nutrition_App.Services.FileServices
{
    public static class SaveWaterToFile
    {
        public static void SaveWaterToFileMethod(string WaterAmount, int difference)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)) + "/water";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string WaterFileName = "w" + CombineDifferenceFileName.CombineDifferenceFileNameMethod(difference);

            using (var writer = new StreamWriter(File.Create(path + "/" + WaterFileName)))
            {
                writer.Write(WaterAmount);
            }
        }
    }
    
}
