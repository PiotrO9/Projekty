using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrition_App.Services.DeveloperConfigure
{
    public static class GetFilesFromPath
    {
        public static string[] GetFilesFromPathMethod(string path)
        {
            string[] array = System.IO.Directory.GetFiles(path);

            return array;
        }
    }
}
