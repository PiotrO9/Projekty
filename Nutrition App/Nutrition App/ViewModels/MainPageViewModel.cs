using Nutrition_App.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Nutrition_App.ViewModels
{
    class MainPageViewModel : BaseViewModel
    {
        public ObservableCollection<MealToDisplay> collection { get; set; }

        public MainPageViewModel()
        {
            Title = "Główna strona";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));

            collection = new ObservableCollection<MealToDisplay>()
            {
                new MealToDisplay(){Name = "Produkt1",Kcal="345",Amount="100g",B="32",T="23",W="67",command= new Command(InvokedCommand)},
                new MealToDisplay(){Name = "Produkt1",Kcal="345",Amount="100g",B="32",T="23",W="67",command= new Command(InvokedCommand)},
                new MealToDisplay(){Name = "Produkt1",Kcal="345",Amount="100g",B="32",T="23",W="67",command= new Command(InvokedCommand)},
                new MealToDisplay(){Name = "Produkt1",Kcal="345",Amount="100g",B="32",T="23",W="67",command= new Command(InvokedCommand)},
            };
        }

        private int _collectionViewHeight;

        public int COllectionViewHeight
        {
            get { return collection.Count * 80; }
            set 
            { 
                _collectionViewHeight = value; 
            }
        }


        public ICommand OpenWebCommand { get; }

        public void InvokedCommand()
        {

        }

    }
}
