using Nutrition_App.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Nutrition_App.Services.Summation_macros
{
   public static class SumKcalFromSingleMeal
    {
        public static float SumKcalFromSingleMealMethod(ObservableCollection<MealToDisplay> collectionOfMeals)
        {
            float sum = 0;

            foreach (var item in collectionOfMeals)
            {
                if (float.TryParse(item.Kcal, out float temp))
                {
                    sum += temp;
                }
            }
            return sum;
        }
    }
}
