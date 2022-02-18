using Nutrition_App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrition_App.Services.ConvertingServices
{
   public static class ChangeRatioMealToDisplay
    {
        public static MealToDisplay ChangeRatioMealToDisplayMethod(MealToDisplay mealToDisplay, float ratio)
        {
            string tempAmount = (ratio * 100).ToString();
            string tempKcal = ((float.Parse(mealToDisplay.Kcal.Remove(mealToDisplay.Kcal.Length - 5, 5))) * ratio).ToString();

            float temp;

            temp = float.Parse(mealToDisplay.B) * ratio;
            temp = (float)(Math.Round((Double)temp, 2));
            string tempB = temp.ToString();

            temp = float.Parse(mealToDisplay.T) * ratio;
            temp = (float)(Math.Round((Double)temp, 2));
            string tempT = temp.ToString();

            temp = float.Parse(mealToDisplay.W) * ratio;
            temp = (float)(Math.Round((Double)temp, 2));
            string tempW = temp.ToString();

            mealToDisplay.Amount = tempAmount;
            mealToDisplay.Kcal = tempKcal;
            mealToDisplay.B = tempB;
            mealToDisplay.T = tempT;
            mealToDisplay.W = tempW;

            return mealToDisplay;
        }
    }
}
