using Nutrition_App.Models;
using Nutrition_App.Services.ConvertingServices;
using Nutrition_App.Services.Scraping;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Nutrition_App.ViewModels
{
    public class AddFoodPageViewModel : BaseViewModel
    {
        private int _numberOfMeal { get; set; }

        private MainPageViewModel _mainPageViewModel { get; set; }

        public AddFoodPageViewModel(int numberOfMeal, MainPageViewModel mainPageViewModel)
        {
            numberOfMeal = _numberOfMeal;
            _mainPageViewModel = mainPageViewModel;

            MealsCollection = new ObservableCollection<MealToDisplay>() { new MealToDisplay{ Name = "test", B = "testing", T = "testing" , W = "testing" }, new MealToDisplay { Name = "test", B = "testing", T = "testing", W = "testing" } };

            SearchButtonClick = new Command(SearchButtonClickImpl);
            OnSelectedCommand = new Command(OnSelectedCommandImpl);
        }

        #region Collections

        private ObservableCollection<MealToDisplay> _mealsCollection;

        public ObservableCollection<MealToDisplay> MealsCollection
        {
            get { return _mealsCollection; }
            set { _mealsCollection = value; OnPropertyChanged(); }
        }

        #endregion

        #region Commands

        public Command SearchButtonClick { get; set; }
        public Command OnSelectedCommand { get; set; }

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

        public void OnSelectedCommandImpl()
        {

        }

        #endregion

        #region Methods


        #endregion

    }
}
