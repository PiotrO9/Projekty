using Nutrition_App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrition_App.Services.ConvertingServices
{
    public static class MealToString
    {
        public static string MealToStringMethod(MealToDisplay mealToDisplay)
        {
            string result = "";

            result += mealToDisplay.Name + "\n";
            result += mealToDisplay.Amount + "\n";
            result += mealToDisplay.B + "\n";
            result += mealToDisplay.T + "\n";
            result += mealToDisplay.W + "\n";
            result += mealToDisplay.Kcal + "\n";
            result += mealToDisplay.ButtonName + "\n";

            return result;
        }
    }
}
