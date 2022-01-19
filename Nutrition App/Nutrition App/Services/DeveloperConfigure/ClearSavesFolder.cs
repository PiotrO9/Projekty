using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Nutrition_App.Services.DeveloperConfigure
{
    public static class ClearSavesFolder
    {
        public static void ClearSavesFolderMethod()
        {
            string[] files = Directory.GetFiles(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)) + "/saves");

            foreach (var file in files)
            {
                File.Delete(file);
            }
        }
    }
}
