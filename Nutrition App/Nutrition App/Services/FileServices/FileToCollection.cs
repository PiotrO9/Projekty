using Nutrition_App.Models;
using Nutrition_App.Services.ConvertingServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace Nutrition_App.Services.FileServices
{
    public static class FileToCollection
    {
        public static List<ObservableCollection<MealToDisplay>> FileToCollectionMethod()
        {
            List<ObservableCollection<MealToDisplay>> ResultCollection = new List<ObservableCollection<MealToDisplay>>();

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)) + "/saves/" + CombineTodayFileName.CombineTodayFileNameMethod();

            try
            {
                using (var reader = new StreamReader(path))
                {
                    string content = reader.ReadToEnd();

                    if (content == "")
                    {
                        return ResultCollection;
                    }
                    else
                    {
                        ResultCollection = StringToMealsList.StringToMealsListMethod(content);
                    }
                }

            }
            catch
            {
                CollectionToFile.CollectionToFileMethod(ResultCollection);
            }

            return ResultCollection;
        }

        public static List<ObservableCollection<MealToDisplay>> FileToCollectionMethod(string fileName)
        {
            List<ObservableCollection<MealToDisplay>> ResultCollection = new List<ObservableCollection<MealToDisplay>>();

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)) + "/saves/" + fileName;

            try
            {
                using (var reader = new StreamReader(path))
                {
                    string content = reader.ReadToEnd();

                    if (content == "")
                    {
                        return ResultCollection;
                    }
                    else
                    {
                        ResultCollection = StringToMealsList.StringToMealsListMethod(content);
                    }
                }

            }
            catch
            {
                CollectionToFile.CollectionToFileMethod(ResultCollection);
            }

            return ResultCollection;
        }
    }
}
