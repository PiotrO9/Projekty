using Nutrition_App.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
            var sb = new StringBuilder();

            foreach (var collection in collections)
            {
                foreach (var meal in collection)
                {
                    if(collection.Count == 0)
                    {
                       sb.Append("!!!\n");
                    }
                    else
                    {
                       sb.Append( MealToString.MealToStringMethod(meal));
                       sb.Append("///\n");
                    }
                }
                sb.Append( "!!!\n");
            }

           sb.Append( "###");
           return sb.ToString() ;
        }
    }
}
