using Nutrition_App.Models;
using Nutrition_App.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Nutrition_App.Services
{
    public static class GetListOfCollectionsMeals
    {
        public static List<ObservableCollection<MealToDisplay>> GetListOfCollectionsMealsMethod(MainPageViewModel mainPageViewModel)
        {
            List<ObservableCollection<MealToDisplay>> LisOfCollectionsMeals = new List<ObservableCollection<MealToDisplay>>();
            LisOfCollectionsMeals.Add(mainPageViewModel.FirstMealCollection);
            LisOfCollectionsMeals.Add(mainPageViewModel.SecondMealCollection);
            LisOfCollectionsMeals.Add(mainPageViewModel.ThirdMealCollection);
            LisOfCollectionsMeals.Add(mainPageViewModel.FourthMealCollection);
            LisOfCollectionsMeals.Add(mainPageViewModel.FifthMealCollection);

            return LisOfCollectionsMeals;
        }
    }
}
