using Nutrition_App.Models;
using Nutrition_App.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrition_App.Services.ConvertingServices
{
    public static class StringsListToMealToDisplay
    {
        public static MealToDisplay StringsListToMealToDisplayMethod(List<string> mealToTransform, int numberOfMeal, MainPageViewModel mainPageViewModel)
        {
            MealToDisplay result = new MealToDisplay();

            if(mealToTransform.Count == 0)
            {
                return result;
            }

            string temp;

            string tempName = mealToTransform[0].Remove(mealToTransform[0].Length - 13,13).Remove(0, 22);
            int kcalTempAmount = int.Parse(mealToTransform[1].Remove(mealToTransform[1].Length - 5, 5).ToString());
            int gTempAmount = int.Parse(mealToTransform[2].Remove(mealToTransform[2].Length - 2, 2).ToString());

            temp = mealToTransform[3].Remove(0, 3).ToString();
            string temp2 = temp.Remove(temp.Length - 2, 2);
            float BTempAmount = float.Parse(temp2);

            temp = mealToTransform[4].Remove(0, 3).ToString();
            float TTempAmount = float.Parse(temp.Remove(temp.Length - 2, 2));

            temp = mealToTransform[5].Remove(0, 3).ToString();
            float WTempAmount = float.Parse(temp.Remove(temp.Length - 2, 2));

            // Liczenie wartości dla 1g oraz 100g

            result.Name = tempName;
            result.Amount = "100";

            float kcalTemp = float.Parse(kcalTempAmount.ToString()) / float.Parse(gTempAmount.ToString());

            float multipliedBy100 = kcalTemp * 100;

            int tempInt = (int)multipliedBy100;

            result.Kcal = tempInt.ToString();

            result.B = ((float)Math.Round((float)((BTempAmount / gTempAmount) * 100), 2)).ToString();
            result.T = ((float)Math.Round((float)((TTempAmount / gTempAmount) * 100), 2)).ToString();
            result.W = ((float)Math.Round((float)((WTempAmount / gTempAmount) * 100), 2)).ToString();
            result.ButtonName = CombineBtnName.CombineBtnNameMethod(numberOfMeal, mainPageViewModel);

            return result;
        }
    }
}
