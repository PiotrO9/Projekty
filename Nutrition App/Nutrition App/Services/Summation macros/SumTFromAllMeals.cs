using Nutrition_App.Models;
using Nutrition_App.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Nutrition_App.Services.Summation_macros
{
    public static class SumTFromAllMeals
    {
        public static float SumTFromAllMealsMethod(MainPageViewModel mainPageViewModel)
        {
            float sum = 0;

            List<ObservableCollection<MealToDisplay>> listOfMealsCollections = GetListOfCollectionsMeals.GetListOfCollectionsMealsMethod(mainPageViewModel);

            foreach (var collection in listOfMealsCollections)
            {
                foreach (var meal in collection)
                {
                    if (float.TryParse(meal.T, out float temp))
                    {
                        sum += temp;
                    }
                }
            }

            return sum;
        }
    }
}
