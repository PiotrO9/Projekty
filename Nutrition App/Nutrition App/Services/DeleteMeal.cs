using Nutrition_App.Services.ConvertingServices;
using Nutrition_App.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrition_App.Services
{
    public static class DeleteMeal
    {
        public static void DeleteMealMethod(MainPageViewModel mainPageViewModel, string ButtonName)
        {
            var numbersoFButtonPosition = GetButtonPosition.GetButtonPositionMethod(ButtonName);

            int MealNumber = numbersoFButtonPosition.Item1;
            int FoodInMealNumber = numbersoFButtonPosition.Item2;

            switch (MealNumber)
            {
                case 1:
                    {
                        mainPageViewModel.FirstMealCollection.RemoveAt(FoodInMealNumber - 1);
                        mainPageViewModel.RenameMealsInCollection(mainPageViewModel.FirstMealCollection);
                        if (mainPageViewModel.FirstMealHeight > 80)
                        {
                            mainPageViewModel.FirstMealHeight -= 80;
                        }
                        break;
                    }
                case 2:
                    {
                        mainPageViewModel.SecondMealCollection.RemoveAt(FoodInMealNumber - 1);
                        mainPageViewModel.RenameMealsInCollection(mainPageViewModel.SecondMealCollection);
                        if (mainPageViewModel.SecondMealHeight > 80)
                        {
                            mainPageViewModel.SecondMealHeight -= 80;
                        }
                        break;
                    }
                case 3:
                    {
                        mainPageViewModel.ThirdMealCollection.RemoveAt(FoodInMealNumber - 1);
                        mainPageViewModel.RenameMealsInCollection(mainPageViewModel.ThirdMealCollection);
                        if (mainPageViewModel.ThirdMealHeight > 80)
                        {
                            mainPageViewModel.ThirdMealHeight -= 80;
                        }
                        break;
                    }
                case 4:
                    {
                        mainPageViewModel.FourthMealCollection.RemoveAt(FoodInMealNumber - 1);
                        mainPageViewModel.RenameMealsInCollection(mainPageViewModel.FourthMealCollection);
                        if (mainPageViewModel.FourthMealHeight > 80)
                        {
                            mainPageViewModel.FourthMealHeight -= 80;
                        }

                        break;
                    }
                case 5:
                    {
                        mainPageViewModel.FifthMealCollection.RemoveAt(FoodInMealNumber - 1);
                        mainPageViewModel.RenameMealsInCollection(mainPageViewModel.FifthMealCollection);
                        if (mainPageViewModel.FifthMealHeight > 80)
                        {
                            mainPageViewModel.FifthMealHeight -= 80;
                        }
                        break;
                    }
            }
            
            SetDetailInformationForEachMeal.SetDetailInformationForEachMealMethod(mainPageViewModel);
            mainPageViewModel.SaveCollections();
            mainPageViewModel.CalculateMacros();
        }
    }
}
