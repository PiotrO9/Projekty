using Nutrition_App.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Nutrition_App.Services.ConvertingServices
{
    public static class MealsListToString
    {
        // ///\n - koniec pojedyńczego dania
        // !!!\n - koniec całego dania, listy
        // ### - koniec całego pliku, listy list

        public static string MealsListToStringMethod(List<ObservableCollection<MealToDisplay>> collections)
        {
            string result = "";

            foreach (var collection in collections)
            {
                foreach (var meal in collection)
                {
                    if(collection.Count == 0)
                    {
                        result += "!!!\n";
                    }
                    else
                    {
                        result += MealToString.MealToStringMethod(meal);
                        result += "///\n";
                    }
                }
                result += "!!!\n";
            }

            result += "###";

            return result;
        }
    }
}
