using Nutrition_App.Models;
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

        public AddFoodDetailsViewModel(MealToDisplay mealToDisplay, string title)
        {
            _mealToDisplay = mealToDisplay;
            Title = title;
        }

        private string _mobilenumber = null;

        public string MobileNumber
        {
            get { return _mobilenumber; }
            set
            {
                _mobilenumber = value;
                TextChangedCommand.Execute(_mobilenumber);
                OnPropertyChanged();
            }
        }

        public Command TextChangedCommand => new Command<string>(async (_mobilenumber) => await TextChanged(_mobilenumber));

        private async Task TextChanged(string p)
        {
            
        }
    }
}