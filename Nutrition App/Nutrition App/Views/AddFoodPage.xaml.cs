using Nutrition_App.Models;
using Nutrition_App.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nutrition_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddFoodPage : ContentPage
    {
        public AddFoodPage(int numberOfMeal, MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();
            BindingContext = new AddFoodPageViewModel(numberOfMeal, mainPageViewModel, MainCollectionView, mainEntry);
        }
    }
}