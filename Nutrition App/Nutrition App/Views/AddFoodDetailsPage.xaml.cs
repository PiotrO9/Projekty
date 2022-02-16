using Nutrition_App.Models;
using Nutrition_App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nutrition_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddFoodDetailsPage : ContentPage
    {
        public AddFoodDetailsPage(MealToDisplay mealToDisplay, string title, MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();
            BindingContext = new AddFoodDetailsViewModel(mealToDisplay, title, mainPageViewModel);
        }
    }
}