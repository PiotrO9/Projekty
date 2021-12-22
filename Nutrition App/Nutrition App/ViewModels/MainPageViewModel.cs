﻿using Nutrition_App.Interfaces;
using Nutrition_App.Models;
using Nutrition_App.Services.ConvertingServices;
using Nutrition_App.Views;
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

        public MainPageViewModel()
        {
            Title = "Główna strona";

            ButtonClickCommand = new Command((parameter) => ButtonClickCommandImpl(parameter));

            BreakfastButtonClickCommand = new Command(BreakfastButtonClickCommandImpl);

            //FirstMealCollection = new ObservableCollection<MealToDisplay>();

            FirstMealCollection = new ObservableCollection<MealToDisplay>()
            {
                new MealToDisplay(){Name = "Produkt12",ButtonName="btn_1_5",Kcal="345",Amount="100g",B="32",T="23",W="67",command=ButtonClickCommand},
                new MealToDisplay(){Name = "Produkt1",ButtonName="btn_1_6",Kcal="345",Amount="100g",B="32",T="23",W="67",command=ButtonClickCommand},
                new MealToDisplay(){Name = "Produkt1",ButtonName="btn_1_7",Kcal="345",Amount="100g",B="32",T="23",W="67",command=ButtonClickCommand},
                new MealToDisplay(){Name = "Produkt1",ButtonName="btn_1_8",Kcal="345",Amount="100g",B="32",T="23",W="67",command=ButtonClickCommand},
            };

            SecondMealCollection = new ObservableCollection<MealToDisplay>()
            {
                new MealToDisplay(){Name = "Produkt1",ButtonName="btn_1_5",Kcal="345",Amount="100g",B="32",T="23",W="67",command=ButtonClickCommand},
                new MealToDisplay(){Name = "Produkt1",ButtonName="btn_1_6",Kcal="345",Amount="100g",B="32",T="23",W="67",command=ButtonClickCommand},
                new MealToDisplay(){Name = "Produkt1",ButtonName="btn_1_7",Kcal="345",Amount="100g",B="32",T="23",W="67",command=ButtonClickCommand},
            };

            ThirdMealCollection = new ObservableCollection<MealToDisplay>();
            FourthMealCollection = new ObservableCollection<MealToDisplay>();
            FifthMealCollection = new ObservableCollection<MealToDisplay>();

            EmptyMealColleciton = new ObservableCollection<MealToDisplay>();
        }

        #region Command implementation

        private void ButtonClickCommandImpl(object parameter)
        {
            string ButtonName = parameter as string;
            if (ButtonName != string.Empty)
            {
                var numbersoFButtonPosition = GetButtonPosition.GetButtonPositionMethod(ButtonName);
            }
        }

        private void BreakfastButtonClickCommandImpl()
        {
            if(FirstMealCollection.Count == 0)
            {
                FirstMealCollection = FirstMealCollectionTemporary;
            }
            else
            {
                FirstMealCollectionTemporary = FirstMealCollection;
                FirstMealCollection = EmptyMealColleciton;
            }

            FirstMealCollectionHeight = FirstMealCollection.Count * _collectionHeight > 10 ? FirstMealCollection.Count * _collectionHeight : 10;
            FirstMealHeight = FirstMealCollectionHeight + _consistentMealHeight;

        }

        #endregion

        #region Collections

        private ObservableCollection<MealToDisplay> _firstMealCollection;

        public ObservableCollection<MealToDisplay> FirstMealCollection
        {
            get { return _firstMealCollection; }
            set { _firstMealCollection = value; OnPropertyChanged(); }
        }

        public ObservableCollection<MealToDisplay> SecondMealCollection { get; set; }
        public ObservableCollection<MealToDisplay> ThirdMealCollection { get; set; }
        public ObservableCollection<MealToDisplay> FourthMealCollection { get; set; }
        public ObservableCollection<MealToDisplay> FifthMealCollection { get; set; }

        #region

        private ObservableCollection<MealToDisplay> _firstMealCollectionTemporary;

        public ObservableCollection<MealToDisplay> FirstMealCollectionTemporary
        {
            get { return _firstMealCollectionTemporary; }
            set { _firstMealCollectionTemporary = value; OnPropertyChanged(); }
        }

        public ObservableCollection<MealToDisplay> SecondMealCollectionTemporary { get; set; }
        public ObservableCollection<MealToDisplay> ThirdMealCollectionTemporary { get; set; }
        public ObservableCollection<MealToDisplay> FourthMealCollectionTemporary { get; set; }
        public ObservableCollection<MealToDisplay> FifthMealCollectionTemporary { get; set; }

        public ObservableCollection<MealToDisplay> EmptyMealColleciton { get; set; }

        #endregion


        #endregion

        #region Commands

        public Command ButtonClickCommand { get; set; }
        public Command BreakfastButtonClickCommand { get; set; }

        #endregion

        #region Heights

        #region GenerallHeights

        private int _consistentMealHeight { get; set; } = 120;

        private int _firstMealHeight;

        public int FirstMealHeight
        {
            get 
            { 
                return FirstMealCollectionHeight + _consistentMealHeight; 
            }
            set 
            {
                _firstMealHeight = value;
                OnPropertyChanged();
            }
        }

        private int _secondMealHeight;

        public int SecondMealHeight
        {
            get 
            {
                return SecondMealCollectionHeight + _consistentMealHeight; 
            }
            set 
            { 
                _secondMealHeight = value;
                OnPropertyChanged();
            }
        }

        private int _thirdMealHeight;

        public int ThirdMealHeight
        {
            get
            {
                return ThirdMealCollectionHeight + _consistentMealHeight;
            }
            set
            {
                _thirdMealHeight = value;
                OnPropertyChanged();
            }
        }

        private int _fourthMealHeight;

        public int FourthMealHeight
        {
            get
            {
                return FourthMealCollectionHeight + _consistentMealHeight;
            }
            set
            {
                _fourthMealHeight = value;
                OnPropertyChanged();
            }
        }

        private int _fifthMealHeight;

        public int FifthMealHeight
        {
            get
            {
                return FifthMealCollectionHeight + _consistentMealHeight;
            }
            set
            {
                _fifthMealHeight = value;
                OnPropertyChanged();
            }
        }


        #endregion

        #region Collection views Height

        private int _collectionHeight { get; set; } = 80;

        private int _firstMealCollectionHeight;

        public int FirstMealCollectionHeight
        {
            get 
            {
                return FirstMealCollection.Count * _collectionHeight > 10 ? FirstMealCollection.Count * _collectionHeight : 10;
            }
            set 
            {
                _firstMealCollectionHeight = value;
                OnPropertyChanged();
            }
        }

        private int _secondMealCollectionHeight;

        public int SecondMealCollectionHeight
        {
            get 
            {
                return SecondMealCollection.Count * _collectionHeight > 10 ? SecondMealCollection.Count * _collectionHeight : 10;

            }
            set
            {
                _secondMealCollectionHeight = value;
                OnPropertyChanged();
            }
        }

        private int _thirdMealCollectionHeight;

        public int ThirdMealCollectionHeight
        {
            get 
            {
                return ThirdMealCollection.Count * _collectionHeight > 10 ? ThirdMealCollection.Count * _collectionHeight : 10;
            }
            set
            {
                _thirdMealCollectionHeight = value;
                OnPropertyChanged();
            }
        }

        private int _fourthMealCollectionHeight;

        public int FourthMealCollectionHeight
        {
            get { return FourthMealCollection.Count * _collectionHeight; }
            set
            {
                _fourthMealCollectionHeight = value;
                OnPropertyChanged();
            }
        }

        private int _fifthMealCollectionHeight;

        public int FifthMealCollectionHeight
        {
            get { return FifthMealCollection.Count * _collectionHeight; }
            set
            {
                _fifthMealCollectionHeight = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #endregion

    }
}
