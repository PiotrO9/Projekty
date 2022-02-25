using Nutrition_App.Models;
using Nutrition_App.Services.ConvertingServices;
using Nutrition_App.Services.DateServices;
using Nutrition_App.Services.Scraping;
using Nutrition_App.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Nutrition_App.ViewModels
{
    public class AddFoodPageViewModel : BaseViewModel
    {
        private int _numberOfMeal { get; set; }

        private MainPageViewModel _mainPageViewModel { get; set; }

        private CollectionView _collectionViewCollection { get; set; }

        private Entry _mainEntry { get; set; }

        public AddFoodPageViewModel(int numberOfMeal, MainPageViewModel mainPageViewModel, CollectionView collectionView, Entry entry)
        {
            _numberOfMeal = numberOfMeal;
            _mainPageViewModel = mainPageViewModel;
            _collectionViewCollection = collectionView;
            _mainEntry = entry;

            SearchButtonClick = new Command(async () => await SearchButtonClickImpl());
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

        public async Task SearchButtonClickImpl()
        {
            string textFromEntry = _mainEntry.Text;

            Scraper scraper = new Scraper();
            List<List<string>> ListOfStringsResults = new List<List<string>>();
            for (int i = 0; i < 18; i++)
            {
                List<string> vs = await scraper.GetProducts(i + 1, textFromEntry, 1);

                ListOfStringsResults.Add(vs);
            }

            if(ListOfStringsResults.Count > 0)
            {
                ObservableCollection<MealToDisplay> mealsToDisplays = new ObservableCollection<MealToDisplay>();

                for (int i = 0; i < ListOfStringsResults.Count; i++)
                {
                    MealToDisplay mealToDisplay = StringsListToMealToDisplay.StringsListToMealToDisplayMethod(ListOfStringsResults[i], _numberOfMeal, _mainPageViewModel);
                    mealToDisplay.Amount += " g";
                    mealToDisplay.Kcal += " kcal";
                    mealsToDisplays.Add(mealToDisplay);
                }

                MealsCollection = mealsToDisplays;
            }
            else
            {
                //Dodać empty template
            }

        }

        public void OnSelectedCommandImpl()
        {
            if (_collectionViewCollection.SelectedItem != null)
            {
                MealToDisplay mealToDisplay = (MealToDisplay)_collectionViewCollection.SelectedItem;

                Application.Current.MainPage.Navigation.PushAsync(new AddFoodDetailsPage(mealToDisplay, GetMealTitle.GetMealTitleMethod(mealToDisplay.ButtonName), _mainPageViewModel));
            }
        }

        #endregion

        #region Methods


        #endregion

    }
}
