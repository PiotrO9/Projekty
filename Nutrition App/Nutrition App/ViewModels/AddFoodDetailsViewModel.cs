using Nutrition_App.Models;
using Nutrition_App.Services.ConvertingServices;
using Nutrition_App.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Nutrition_App.ViewModels
{
    class AddFoodDetailsViewModel : BaseViewModel
    {
        private MealToDisplay _mealToDisplay { get; set; }

        private MainPageViewModel _mainPageViewModel { get; set; }

        public AddFoodDetailsViewModel(MealToDisplay mealToDisplay, string title, MainPageViewModel mainPageViewModel)
        {
            _mealToDisplay = mealToDisplay;
            _mainPageViewModel = mainPageViewModel;
            Title = title;

            FristCommand = new Command(FristCommandImpl);
            SecondCommand = new Command(SecondCommandImpl);
            ThirdCommand = new Command(ThirdCommandImpl);
            FourthCommand = new Command(FourthCommandImpl);

            SetValuesOnStart();
        }

        #region Commands

        public Command FristCommand { get; set; }
        public Command SecondCommand { get; set; }
        public Command ThirdCommand { get; set; }
        public Command FourthCommand { get; set; }

        #endregion

        #region Impl

        public void FristCommandImpl()
        {
            MealToDisplay test = ChangeRatioMealToDisplay.ChangeRatioMealToDisplayMethod(_mealToDisplay, 0.5f);
            test.command = _mainPageViewModel.ButtonClickCommand;

            var numbersoFButtonPosition = GetButtonPosition.GetButtonPositionMethod(test.ButtonName);

            switch(numbersoFButtonPosition.Item1)
            {
                case 1:
                    {
                        _mainPageViewModel.FirstMealCollection.Add(test);
                        break;
                    }
            }

            _mainPageViewModel.SaveCollections();

            Application.Current.MainPage.Navigation.PushAsync(new MainPage());
        }

        public void SecondCommandImpl()
        {

        }

        public void ThirdCommandImpl()
        {

        }

        public void FourthCommandImpl()
        {

        }

        #endregion

        #region Options

        #region Amount options

        private string _optionFirstAmount;
        public string OptionFirstAmount
        {
            get { return _optionFirstAmount; }
            set { _optionFirstAmount = value + " g"; OnPropertyChanged(); }
        }

        private string _optionSecondAmount;
        public string OptionSecondAmount
        {
            get { return _optionSecondAmount; }
            set { _optionSecondAmount = value + " g"; OnPropertyChanged(); }
        }

        private string _optionThirdAmount;
        public string OptionThirdAmount
        {
            get { return _optionThirdAmount; }
            set { _optionThirdAmount = value + " g"; OnPropertyChanged(); }
        }

        private string _optionFourthAmount;
        public string OptionFourthAmount
        {
            get { return _optionFourthAmount; }
            set { _optionFourthAmount = value + " g"; OnPropertyChanged(); }
        }

        #endregion

        #region Kcal options

        private string _optionFirstKcal;

        public string OptionFirstKcal
        {
            get { return _optionFirstKcal; }
            set { _optionFirstKcal = value + " kcal"; OnPropertyChanged(); }
        }

        private string _optionSecondKcal;

        public string OptionSecondKcal
        {
            get { return _optionSecondKcal; }
            set { _optionSecondKcal = value + " kcal"; OnPropertyChanged(); }
        }

        private string _optionThirdKcal;

        public string OptionThirdKcal
        {
            get { return _optionThirdKcal; }
            set { _optionThirdKcal = value + " kcal"; OnPropertyChanged(); }
        }

        private string _optionFourthKcal;

        public string OptionFourthKcal
        {
            get { return _optionFourthKcal; }
            set { _optionFourthKcal = value + " kcal"; OnPropertyChanged(); }
        }


        #endregion

        #endregion

        #region Entry

        private string _entryText = null;
        public string EntryText
        {
            get { return _entryText; }
            set
            {
                _entryText = value;
                TextChangedCommand.Execute(_entryText);
                OnPropertyChanged();
            }
        }

        public Command TextChangedCommand => new Command<string>(async (_entryText) => await TextChanged(_entryText));

        private async Task TextChanged(string p)
        {
            if (p == string.Empty)
            {
                EntryText = "0";
            }
            else
            {
                float temp = float.Parse(EntryText) / 100;
                float kcal = float.Parse(_mealToDisplay.Kcal.Remove(_mealToDisplay.Kcal.Length - 5, 5));

                OptionFourthKcal = (kcal * temp).ToString();
            }
        }

        #endregion

        #region Methods

        public void SetValuesOnStart()
        {
            float amount = float.Parse(_mealToDisplay.Amount.Remove(_mealToDisplay.Amount.Length - 2, 2)); //ilość na 100g
            float kcal = float.Parse(_mealToDisplay.Kcal.Remove(_mealToDisplay.Kcal.Length - 5, 5));
            OptionFirstAmount = (amount / 2).ToString();
            OptionFirstKcal = (kcal / 2).ToString();

            OptionSecondAmount = amount.ToString();
            OptionSecondKcal = kcal.ToString();

            OptionThirdAmount = (amount * 2).ToString();
            OptionThirdKcal = (kcal * 2).ToString();
        }

        #endregion
    }
}