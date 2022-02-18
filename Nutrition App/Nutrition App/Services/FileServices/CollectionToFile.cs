using Nutrition_App.Models;
using Nutrition_App.Services.ConvertingServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace Nutrition_App.Services.FileServices
{
    public static class CollectionToFile
    {
        public static void CollectionToFileMethod(List<ObservableCollection<MealToDisplay>> collection, int difference)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)) + "/saves";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string todayFileName = CombineDifferenceFileName.CombineDifferenceFileNameMethod(difference);

            using (var writer = new StreamWriter(File.Create(path + "/" + todayFileName)))
            {
                string ContentToSave = MealsListToString.MealsListToStringMethod(collection);

                writer.Write(ContentToSave);
            }
        }
    }
}
