using Nutrition_App.Models;
using Nutrition_App.Services.Summation_macros;
using Nutrition_App.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Nutrition_App.Services
{
    public static class SetDetailInformationForEachMeal
    {
        private static float _tempB { get; set; }
        private static float _tempW { get; set; }
        private static float _tempT { get; set; }
        private static float _tempKcal { get; set; }

        private static ObservableCollection<MealToDisplay> _tempCollection { get; set; }

        public static void SetDetailInformationForEachMealMethod(MainPageViewModel mainPageViewModel)
        {
            #region Breakfast

            _tempCollection = mainPageViewModel.FirstMealCollection;

            _tempB = SumBFromSingleMeal.SumBFromSingleMealMethod(_tempCollection);
            _tempT = SumTFromSingleMeal.SumTFromSingleMealMethod(_tempCollection);
            _tempW = SumWFromSingleMeal.SumWFromSingleMealMethod(_tempCollection);
            _tempKcal = SumKcalFromSingleMeal.SumKcalFromSingleMealMethod(_tempCollection);

            mainPageViewModel.BreakfastBTotalAmount = _tempB.ToString();
            mainPageViewModel.BreakfastTTotalAmount = _tempT.ToString();
            mainPageViewModel.BreakfastWTotalAmount = _tempW.ToString();
            mainPageViewModel.BreakfastKcalTotalAmount = _tempKcal.ToString();

            ResetProperitiesInsideClass();

            #endregion

            #region Second breakfast

            _tempCollection = mainPageViewModel.SecondMealCollection;

            _tempB = SumBFromSingleMeal.SumBFromSingleMealMethod(_tempCollection);
            _tempT = SumTFromSingleMeal.SumTFromSingleMealMethod(_tempCollection);
            _tempW = SumWFromSingleMeal.SumWFromSingleMealMethod(_tempCollection);
            _tempKcal = SumKcalFromSingleMeal.SumKcalFromSingleMealMethod(_tempCollection);

            mainPageViewModel.SecondBreakfastBTotalAmount = _tempB.ToString();
            mainPageViewModel.SecondBreakfastTTotalAmount = _tempT.ToString();
            mainPageViewModel.SecondBreakfastWTotalAmount = _tempW.ToString();
            mainPageViewModel.SecondBreakfastKcalTotalAmount = _tempKcal.ToString();

            ResetProperitiesInsideClass();

            #endregion

            #region Lunch

            _tempCollection = mainPageViewModel.ThirdMealCollection;

            _tempB = SumBFromSingleMeal.SumBFromSingleMealMethod(_tempCollection);
            _tempT = SumTFromSingleMeal.SumTFromSingleMealMethod(_tempCollection);
            _tempW = SumWFromSingleMeal.SumWFromSingleMealMethod(_tempCollection);
            _tempKcal = SumKcalFromSingleMeal.SumKcalFromSingleMealMethod(_tempCollection);

            mainPageViewModel.LunchBTotalAmount = _tempB.ToString();
            mainPageViewModel.LunchTTotalAmount = _tempT.ToString();
            mainPageViewModel.LunchWTotalAmount = _tempW.ToString();
            mainPageViewModel.LunchKcalTotalAmount = _tempKcal.ToString();

            ResetProperitiesInsideClass();

            #endregion

            #region Dinner

            _tempCollection = mainPageViewModel.FourthMealCollection;

            _tempB = SumBFromSingleMeal.SumBFromSingleMealMethod(_tempCollection);
            _tempT = SumTFromSingleMeal.SumTFromSingleMealMethod(_tempCollection);
            _tempW = SumWFromSingleMeal.SumWFromSingleMealMethod(_tempCollection);
            _tempKcal = SumKcalFromSingleMeal.SumKcalFromSingleMealMethod(_tempCollection);

            mainPageViewModel.DinnerBTotalAmount = _tempB.ToString();
            mainPageViewModel.DinnerTTotalAmount = _tempT.ToString();
            mainPageViewModel.DinnerWTotalAmount = _tempW.ToString();
            mainPageViewModel.DinnerKcalTotalAmount = _tempKcal.ToString();

            ResetProperitiesInsideClass();

            #endregion

            #region Supper

            _tempCollection = mainPageViewModel.FifthMealCollection;

            _tempB = SumBFromSingleMeal.SumBFromSingleMealMethod(_tempCollection);
            _tempT = SumTFromSingleMeal.SumTFromSingleMealMethod(_tempCollection);
            _tempW = SumWFromSingleMeal.SumWFromSingleMealMethod(_tempCollection);
            _tempKcal = SumKcalFromSingleMeal.SumKcalFromSingleMealMethod(_tempCollection);

            mainPageViewModel.SupperBTotalAmount = _tempB.ToString();
            mainPageViewModel.SupperTTotalAmount = _tempT.ToString();
            mainPageViewModel.SupperWTotalAmount = _tempW.ToString();
            mainPageViewModel.SupperKcalTotalAmount = _tempKcal.ToString();

            ResetProperitiesInsideClass();

            #endregion
        }

        private static void ResetProperitiesInsideClass()
        {
            _tempB = 0;
            _tempT = 0;
            _tempW = 0;
            _tempKcal = 0;
        }
    }
}
