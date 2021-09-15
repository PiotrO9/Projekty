using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dziennik_treningowy.Services.Setting_services
{
    public static class Set_Exercises
    {
        public static void Method()
        {
            string MainPath = System.Environment.GetFolderPath(
              System.Environment.SpecialFolder.Personal);

            string ExcersiseFolderPath = MainPath + "/ExcersiseFolderPath";

            if (!Directory.Exists(ExcersiseFolderPath))
            {
                Directory.CreateDirectory(ExcersiseFolderPath);
            }
            

        }
    }
}
