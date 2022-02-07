using Nutrition_App.Models;
using Nutrition_App.Services.ConvertingServices;
using Nutrition_App.Services.Scraping;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Nutrition_App.ViewModels
{
    class AddFoodPageViewModel : BaseViewModel
    {
        private int _numberOfMeal { get; set; }

        private MainPageViewModel _mainPageViewModel { get; set; }

        public AddFoodPageViewModel(int numberOfMeal, MainPageViewModel mainPageViewModel)
        {
            numberOfMeal = _numberOfMeal;
            _mainPageViewModel = mainPageViewModel;

            SearchButtonClick = new Command(SearchButtonClickImpl);
        }

        # region Commands

        public Command SearchButtonClick { get; set; }

        #endregion

        #region Commands impl

        public void SearchButtonClickImpl()
        {
            Scraper scraper = new Scraper();
            List<List<string>> temp = new List<List<string>>();
            for (int i = 0; i < 18; i++)
            {
                List<string> vs = scraper.GetProducts(i + 1, "Ryż biały", 1);

                temp.Add(vs);
            }

            if(temp.Count > 0)
            {
               MealToDisplay mealToDisplay = StringsListToMealToDisplay.StringsListToMealToDisplayMethod(temp[1], 1, _mainPageViewModel);
            }
            else
            {

            }


        }

        #endregion

        #region



        #endregion

    }
}
