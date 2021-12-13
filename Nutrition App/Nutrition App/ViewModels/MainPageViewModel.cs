using Nutrition_App.Models;
using Nutrition_App.Services.ConvertingServices;
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

        public Command ButtonClickCommand { get; set; }

        public MainPageViewModel()
        {
            Title = "Główna strona";

            ButtonClickCommand = new Command(
            (parameter) =>
            {
                var view = parameter as Xamarin.Forms.Button;
                if (view != null)
                {
                    var numbersoFButtonPosition = GetButtonPosition.GetButtonPositionMethod(view);

                }
            });

            collection = new ObservableCollection<MealToDisplay>()
            {
                new MealToDisplay(){Name = "Produkt1",ButtonName="btn_1_5",Kcal="345",Amount="100g",B="32",T="23",W="67",command = ButtonClickCommand},
                new MealToDisplay(){Name = "Produkt1",Kcal="345",Amount="100g",B="32",T="23",W="67"},
                new MealToDisplay(){Name = "Produkt1",Kcal="345",Amount="100g",B="32",T="23",W="67"},
                new MealToDisplay(){Name = "Produkt1",Kcal="345",Amount="100g",B="32",T="23",W="67"},
            };
        }      

        #region Collections



        #endregion

        #region Commands

        #endregion

        #region Collection views Height

        private int _collectionViewHeight;

        public int COllectionViewHeight
        {
            get { return collection.Count * 80; }
            set 
            { 
                _collectionViewHeight = value; 
            }
        }

        #endregion

    }
}
