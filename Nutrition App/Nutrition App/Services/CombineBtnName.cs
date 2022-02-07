using Nutrition_App.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrition_App.Services
{
    public static class CombineBtnName
    {
        public static string CombineBtnNameMethod(int numberOfMeal, MainPageViewModel mainPageViewModel)
        {
            string result = "btn_" + numberOfMeal + "_";
            int temp;

            switch (numberOfMeal)
            {
                case 1:
                    {
                        temp = mainPageViewModel.FirstMealCollection.Count + 1;
                        result += temp.ToString();
                        break;
                    }
                case 2:
                    {
                        temp = mainPageViewModel.SecondMealCollection.Count + 1;
                        result += temp.ToString();
                        break;
                    }
                case 3:
                    {
                        temp = mainPageViewModel.ThirdMealCollection.Count + 1;
                        result += temp.ToString();
                        break;
                    }
                case 4:
                    {
                        temp = mainPageViewModel.FourthMealCollection.Count + 1;
                        result += temp.ToString();
                        break;
                    }
                case 5:
                    {
                        temp = mainPageViewModel.FifthMealCollection.Count + 1;
                        result += temp.ToString();
                        break;
                    }
                default:
                    {
                        return string.Empty;
                    }
            }

            return result;
        }
    }
}
