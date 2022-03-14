using Nutrition_App.Views.Popups;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Nutrition_App.ViewModels.PopupsViewModels
{
    public class MacrosInfoPopupViewModel : BaseViewModel
    {
        public MacrosInfoPopupViewModel(string TextToDisplay, MacrosInfoPopup macrosInfoPopup)
        {
            _mip = macrosInfoPopup;

            if (IsCorrect(TextToDisplay))
                MainText = TextToDisplay;
            else
                MainText = "Wprowadzono nieprawidłowe dane";

            MainButtonClickCommand = new Command(MainButtonClickCommandImpl);
        }

        private MacrosInfoPopup _mip { get; set; }

        private string _mainText;

        public string MainText
        {
            get { return _mainText; }
            private set { _mainText = value; OnPropertyChanged(); }
        }

        public Command MainButtonClickCommand { get; set; }

        private void MainButtonClickCommandImpl()
        {
            _mip.Dismiss(null);
        }

        public bool IsCorrect(string temp)
        {
            if(String.IsNullOrWhiteSpace(temp))
                return false;

            if(temp.Length <= 10)
                return false;

            return true;
        }
    }
}
