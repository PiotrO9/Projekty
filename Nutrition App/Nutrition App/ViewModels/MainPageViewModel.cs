﻿using Acr.UserDialogs;
using Nutrition_App.Interfaces;
using Nutrition_App.Models;
using Nutrition_App.Services;
using Nutrition_App.Services.ConvertingServices;
using Nutrition_App.Services.DateServices;
using Nutrition_App.Services.DeveloperConfigure;
using Nutrition_App.Services.FileServices;
using Nutrition_App.Services.Summation_macros;
using Nutrition_App.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Nutrition_App.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPage _mainPage { get; set; }

        public MainPageViewModel(MainPage mainPage)
        {
            Title = "Główna strona";

            _mainPage = mainPage;

            DaysDifference = 0;

            #region Common

            ButtonClickCommand = new Command((parameter) => ButtonClickCommandImpl(parameter));
            DaysButtonClickCommand = new Command((parametr) => DaysButtonClickCommandImpl(parametr));

            TotalWaterAmount = int.Parse(Preferences.Get("TotalWaterAmount", "2000"));
            CapacityOfWater = int.Parse(Preferences.Get("CapacityOfWater", "250"));

            KcalSubmitLimit = Preferences.Get("KcalSubmitLimit", "2500");
            BSubmitLimit = Preferences.Get("BSubmitLimit", "150");
            TSubmitLimit = Preferences.Get("TSubmitLimit", "100");
            WSubmitLimit = Preferences.Get("WSubmitLimit", "450");

            CurrentAmountOfWater = int.Parse(ReadFileToWater.ReadFileToWaterMethod(DaysDifference));

            SetDaysBinding();

            AddWaterClick = new Command(AddWaterClickImpl);
            SubWaterClick = new Command(SubWaterClickImpl);

            BreakfastButtonClickCommand = new Command(BreakfastButtonClickCommandImpl);
            SecondBreakfastButtonClickCommand = new Command(SecondBreakfastButtonClickCommandImpl);
            LunchButtonClickCommand = new Command(LunchButtonClickCommandImpl);
            DinnerButtonClickCommand = new Command(DinnerButtonClickCommandImpl);
            SupperButtonClickCommand = new Command(SupperButtonClickCommandImpl);

            AddFoodToMealClickCommand = new Command((parametr) => AddFoodToMealClickCommandImpl(parametr));

            EmptyMealColleciton = new ObservableCollection<MealToDisplay>();

            #endregion

            List<ObservableCollection<MealToDisplay>> LoadedCollection = FileToCollection.FileToCollectionMethod(DaysDifference);
            FillByMissingCommand(LoadedCollection);
            UpdateCollections(LoadedCollection);

            CheckIfCollectionsAreNotNull();
            CalculateMacros();
        }

        public MainPageViewModel(int difference, MainPage mainPage)
        {
            Title = "Główna strona";

            _mainPage = mainPage;

            DaysDifference = difference;

            #region Common

            ButtonClickCommand = new Command((parameter) => ButtonClickCommandImpl(parameter));
            DaysButtonClickCommand = new Command((parametr) => DaysButtonClickCommandImpl(parametr));

            TotalWaterAmount = int.Parse(Preferences.Get("TotalWaterAmount", "2000"));
            CapacityOfWater = int.Parse(Preferences.Get("CapacityOfWater", "250"));

            KcalSubmitLimit = Preferences.Get("KcalSubmitLimit", "2500");
            BSubmitLimit = Preferences.Get("BSubmitLimit", "150");
            TSubmitLimit = Preferences.Get("TSubmitLimit", "100");
            WSubmitLimit = Preferences.Get("WSubmitLimit", "450");

            CurrentAmountOfWater = int.Parse(ReadFileToWater.ReadFileToWaterMethod(DaysDifference));

            SetDaysBinding(DaysDifference);

            AddWaterClick = new Command(AddWaterClickImpl);
            SubWaterClick = new Command(SubWaterClickImpl);

            BreakfastButtonClickCommand = new Command(BreakfastButtonClickCommandImpl);
            SecondBreakfastButtonClickCommand = new Command(SecondBreakfastButtonClickCommandImpl);
            LunchButtonClickCommand = new Command(LunchButtonClickCommandImpl);
            DinnerButtonClickCommand = new Command(DinnerButtonClickCommandImpl);
            SupperButtonClickCommand = new Command(SupperButtonClickCommandImpl);

            AddFoodToMealClickCommand = new Command((parametr) => AddFoodToMealClickCommandImpl(parametr));

            EmptyMealColleciton = new ObservableCollection<MealToDisplay>();

            #endregion

            List<ObservableCollection<MealToDisplay>> LoadedCollection = FileToCollection.FileToCollectionMethod(CombineDifferenceFileName.CombineDifferenceFileNameMethod(DaysDifference), DaysDifference);
            FillByMissingCommand(LoadedCollection);
            UpdateCollections(LoadedCollection);

            CheckIfCollectionsAreNotNull();
            CalculateMacros();
        }

        #region Methods
        public void SetDaysBinding(int difference = 0)
        {
            string[] DaysInformation = CombineDateInformation.CombineDateInformationMethod(difference);

            TwoDaysAgoText = DaysInformation[0];
            YesterdayText = DaysInformation[1];
            TodayText = DaysInformation[2];
            TomorrowText = DaysInformation[3];
            InTwoDays = DaysInformation[4];
        }

        public float CalculateCurrentWaterState()
        {
            float calculation = float.Parse(CurrentAmountOfWater.ToString()) / float.Parse(TotalWaterAmount.ToString());

            if (calculation >= 1.0)
            {
                return 1.0F;
            }
            else
            {
                return calculation;
            }
        }

        public void UpdateCollections(List<ObservableCollection<MealToDisplay>> collections)
        {
            if (collections.Count >= 5)
            {
                FirstMealCollection = collections[0];
                SecondMealCollection = collections[1];
                ThirdMealCollection = collections[2];
                FourthMealCollection = collections[3];
                FifthMealCollection = collections[4];
            }
        }

        public void CheckIfCollectionsAreNotNull()
        {
            if (FirstMealCollection == null)
            {
                FirstMealCollection = new ObservableCollection<MealToDisplay>();
                FirstMealCollectionTemporary = new ObservableCollection<MealToDisplay>();
            }

            if (SecondMealCollection == null)
            {
                SecondMealCollection = new ObservableCollection<MealToDisplay>();
                SecondMealCollectionTemporary = new ObservableCollection<MealToDisplay>();
            }

            if (ThirdMealCollection == null)
            {
                ThirdMealCollection = new ObservableCollection<MealToDisplay>();
                ThirdMealCollectionTemporary = new ObservableCollection<MealToDisplay>();
            }

            if (FourthMealCollection == null)
            {
                FourthMealCollection = new ObservableCollection<MealToDisplay>();
                FourthMealCollectionTemporary = new ObservableCollection<MealToDisplay>();
            }

            if (FifthMealCollection == null)
            {
                FifthMealCollection = new ObservableCollection<MealToDisplay>();
                FifthMealCollectionTemporary = new ObservableCollection<MealToDisplay>();
            }
        }

        public void FillByMissingCommand(List<ObservableCollection<MealToDisplay>> collections)
        {
            foreach (var collection in collections)
            {
                foreach (var item in collection)
                {
                    item.command = ButtonClickCommand;
                }
            }
        }

        public int DetectWhichDayButtonClicked(string btnText)
        {
            int difference = 0;

            if (btnText == TwoDaysAgoText)
            {
                difference = -2;
            }
            else if (btnText == YesterdayText)
            {
                difference = -1;
            }
            else if (btnText == TodayText)
            {
                difference = 0;
            }
            else if (btnText == TomorrowText)
            {
                difference = 1;
            }
            else if (btnText == InTwoDays)
            {
                difference = 2;
            }

            return difference;
        }

        public void SaveCollections()
        {
            List<ObservableCollection<MealToDisplay>> ListOfCollections = new List<ObservableCollection<MealToDisplay>>();
            ListOfCollections.Add(FirstMealCollection);
            ListOfCollections.Add(SecondMealCollection);
            ListOfCollections.Add(ThirdMealCollection);
            ListOfCollections.Add(FourthMealCollection);
            ListOfCollections.Add(FifthMealCollection);

            CollectionToFile.CollectionToFileMethod(ListOfCollections, DaysDifference);
        }

        public void CalculateMacros()
        {
            #region Total part

            float sumOfKcal = SumKcalFromAllMeals.SumKcalFromAllMealsMethod(this);
            float sumOfB = SumBFromAllMeals.SumBFromAllMealsMethod(this);
            float sumOfT = SumTFromAllMeals.SumTFromAllMealsMethod(this);
            float sumOfW = SumWFromAllMeals.SumWFromAllMealsMethod(this);

            if (sumOfKcal == 0)
            {
                KcalProgressBarState = 0;
            }
            else
            {
                try
                {
                    KcalProgressBarState = sumOfKcal / float.Parse(KcalSubmitLimit.Remove(0, 1).Remove(KcalSubmitLimit.Length - 6, 5));
                }
                catch (DivideByZeroException)
                {
                    KcalProgressBarState = 0;
                }
            }

            if (sumOfB == 0)
            {
                BProgressBarState = 0;
            }
            else
            {
                try
                {
                    BProgressBarState = sumOfB / float.Parse(BSubmitLimit.Remove(BSubmitLimit.Length - 2, 2).Remove(0, 1));
                }
                catch (DivideByZeroException)
                {
                    BProgressBarState = 0;
                }
            }

            if (sumOfT == 0)
            {
                TProgressBarState = 0;
            }
            else
            {
                try
                {
                    TProgressBarState = sumOfT / float.Parse(TSubmitLimit.Remove(TSubmitLimit.Length - 2, 2).Remove(0, 1));
                }
                catch (DivideByZeroException)
                {
                    TProgressBarState = 0;
                }
            }

            if (sumOfW == 0)
            {
                WProgressBarState = 0;
            }
            else
            {
                try
                {
                    WProgressBarState = sumOfW / float.Parse(WSubmitLimit.Remove(WSubmitLimit.Length - 2, 2).Remove(0, 1));
                }
                catch (DivideByZeroException)
                {
                    WProgressBarState = 0;
                }
            }

            #endregion

            #region Each meal details

            SetDetailInformationForEachMeal.SetDetailInformationForEachMealMethod(this);

            #endregion
        }

        public void RenameMealsInCollection(ObservableCollection<MealToDisplay> mealToDisplays)
        {
            if (mealToDisplays == null)
                return;

            int length = mealToDisplays.Count;

            if (length > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    var numbersoFButtonPosition = GetButtonPosition.GetButtonPositionMethod(mealToDisplays[i].ButtonName);

                    mealToDisplays[i].ButtonName = "btn_" + numbersoFButtonPosition.Item1.ToString() + "_" + (i + 1).ToString(); 
                }
            }
        }

    #endregion

    #region Command implementation

    private void ButtonClickCommandImpl(object parameter)
    {
        if (parameter is string ButtonName)
            {
                if(!String.IsNullOrWhiteSpace(ButtonName))
                {
                    DeleteMeal.DeleteMealMethod(this, ButtonName);
                    var numbersoFButtonPosition = GetButtonPosition.GetButtonPositionMethod(ButtonName);
                }
            }
    }

    private void DaysButtonClickCommandImpl(object parametr)
    {
        Button WorkButton = parametr as Button;
        string ButtonText = WorkButton.Text;
        string[] SingleWordsArray = ButtonText.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

        string result = CombineFileName.CombineFileNameMethod(SingleWordsArray);
        DaysDifference += DetectWhichDayButtonClicked(WorkButton.Text);
        Application.Current.MainPage.Navigation.PushAsync(new MainPage(DaysDifference));
    }

    private void BreakfastButtonClickCommandImpl()
        {
            if (FirstMealCollection != null)
            {
                if (FirstMealCollection.Count == 0)
                {
                    if(FirstMealCollectionTemporary == null || FirstMealCollectionTemporary.Count == 0)
                    {
                        return;
                    }

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
        }
    private void SecondBreakfastButtonClickCommandImpl()
        {
            if (SecondMealCollection != null)
            {
                if (SecondMealCollection.Count == 0)
                {
                    if(SecondMealCollectionTemporary == null || SecondMealCollectionTemporary.Count == 0)
                    {
                        return;
                    }
                    SecondMealCollection = SecondMealCollectionTemporary;
                }
                else
                {
                    SecondMealCollectionTemporary = SecondMealCollection;
                    SecondMealCollection = EmptyMealColleciton;
                }

                SecondMealCollectionHeight = SecondMealCollection.Count * _collectionHeight > 10 ? SecondMealCollection.Count * _collectionHeight : 10;
                SecondMealHeight = SecondMealCollectionHeight + _consistentMealHeight;
            }

        }
    private void LunchButtonClickCommandImpl()
        {
            if (ThirdMealCollection != null)
            {
                if (ThirdMealCollection.Count == 0)
                {
                    if (ThirdMealCollectionTemporary == null || ThirdMealCollectionTemporary.Count == 0)
                    {
                        return;
                    }
                    ThirdMealCollection = ThirdMealCollectionTemporary;
                }
                else
                {
                    ThirdMealCollectionTemporary = ThirdMealCollection;
                    ThirdMealCollection = EmptyMealColleciton;
                }

                ThirdMealCollectionHeight = ThirdMealCollection.Count * _collectionHeight > 10 ? ThirdMealCollection.Count * _collectionHeight : 10;
                ThirdMealHeight = ThirdMealCollectionHeight + _consistentMealHeight;
            }

        }
    private void DinnerButtonClickCommandImpl()
    {
        if(FourthMealCollection != null)
            {
                if (FourthMealCollection.Count == 0)
                {
                    if (FourthMealCollectionTemporary == null || FourthMealCollectionTemporary.Count == 0)
                    {
                        return;
                    }
                    FourthMealCollection = FourthMealCollectionTemporary;
                }

                else
                {
                    FourthMealCollectionTemporary = FourthMealCollection;
                    FourthMealCollection = EmptyMealColleciton;
                }

                FourthMealCollectionHeight = FourthMealCollection.Count * _collectionHeight > 10 ? FourthMealCollection.Count * _collectionHeight : 10;
                FourthMealHeight = FourthMealCollectionHeight + _consistentMealHeight;
            }
        
    }
    private void SupperButtonClickCommandImpl()
    {
        if(FifthMealCollection != null)
            {
                if (FifthMealCollection.Count == 0)
                {
                    if (FifthMealCollectionTemporary == null || FifthMealCollectionTemporary.Count == 0)
                    {
                        return;
                    }
                    FifthMealCollection = FifthMealCollectionTemporary;
                }
                else
                {
                    FifthMealCollectionTemporary = FifthMealCollection;
                    FifthMealCollection = EmptyMealColleciton;
                }

                FifthMealCollectionHeight = FifthMealCollection.Count * _collectionHeight > 10 ? FifthMealCollection.Count * _collectionHeight : 10;
                FifthMealHeight = FifthMealCollectionHeight + _consistentMealHeight;
            }

    }

    private void AddWaterClickImpl()
    {
        if (CurrentAmountOfWater < TotalWaterAmount)
        {
            CurrentAmountOfWater += CapacityOfWater;
            SaveWaterToFile.SaveWaterToFileMethod(CurrentAmountOfWater.ToString(), DaysDifference);
        }                         
    }

    private void SubWaterClickImpl()
    {
        if (CurrentAmountOfWater > CapacityOfWater)
        {
            CurrentAmountOfWater -= CapacityOfWater;
        }
        else
        {
            CurrentAmountOfWater = 0;
        }

        SaveWaterToFile.SaveWaterToFileMethod(CurrentAmountOfWater.ToString(), DaysDifference);
    }

    private void AddFoodToMealClickCommandImpl(object parametr)
    {
        int numberOfMeal = int.Parse(parametr.ToString());

        Application.Current.MainPage.Navigation.PushAsync(new AddFoodPage(numberOfMeal, this));
    }

    #endregion

    #region Collections

    private ObservableCollection<MealToDisplay> _firstMealCollection;

    public ObservableCollection<MealToDisplay> FirstMealCollection
    {
        get { return _firstMealCollection; }
        set { _firstMealCollection = value; OnPropertyChanged(); }
    }

    private ObservableCollection<MealToDisplay> _secondMealCollection;

    public ObservableCollection<MealToDisplay> SecondMealCollection
    {
        get { return _secondMealCollection; }
        set { _secondMealCollection = value; OnPropertyChanged(); }
    }

    private ObservableCollection<MealToDisplay> _thirdMealCollection;

    public ObservableCollection<MealToDisplay> ThirdMealCollection
    {
        get { return _thirdMealCollection; }
        set { _thirdMealCollection = value; OnPropertyChanged(); }
    }

    private ObservableCollection<MealToDisplay> _fourthMealCollection;

    public ObservableCollection<MealToDisplay> FourthMealCollection
    {
        get { return _fourthMealCollection; }
        set { _fourthMealCollection = value; OnPropertyChanged(); }
    }

    private ObservableCollection<MealToDisplay> _fifthMealCollection;

    public ObservableCollection<MealToDisplay> FifthMealCollection
    {
        get { return _fifthMealCollection; }
        set { _fifthMealCollection = value; OnPropertyChanged(); }
    }

    #region

    public ObservableCollection<MealToDisplay> FirstMealCollectionTemporary { get; set; }
    public ObservableCollection<MealToDisplay> SecondMealCollectionTemporary { get; set; }
    public ObservableCollection<MealToDisplay> ThirdMealCollectionTemporary { get; set; }
    public ObservableCollection<MealToDisplay> FourthMealCollectionTemporary { get; set; }
    public ObservableCollection<MealToDisplay> FifthMealCollectionTemporary { get; set; }

    public ObservableCollection<MealToDisplay> EmptyMealColleciton { get; set; }

    #endregion


    #endregion

    #region Commands

    public Command ButtonClickCommand { get; set; }
    public Command DaysButtonClickCommand { get; set; }



    public Command BreakfastButtonClickCommand { get; set; }
    public Command SecondBreakfastButtonClickCommand { get; set; }
    public Command LunchButtonClickCommand { get; set; }
    public Command DinnerButtonClickCommand { get; set; }
    public Command SupperButtonClickCommand { get; set; }



    public Command AddWaterClick { get; set; }
    public Command SubWaterClick { get; set; }

    public Command AddFoodToMealClickCommand { get; set; }

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
        get
        {
            return FourthMealCollection.Count * _collectionHeight > 10 ? FourthMealCollection.Count * _collectionHeight : 10;
        }
        set
        {
            _fourthMealCollectionHeight = value;
            OnPropertyChanged();
        }
    }

    private int _fifthMealCollectionHeight;

    public int FifthMealCollectionHeight
    {
        get
        {
            return FifthMealCollection.Count * _collectionHeight > 10 ? FifthMealCollection.Count * _collectionHeight : 10;
        }
        set
        {
            _fifthMealCollectionHeight = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #endregion

    #region Fields

    #region Water fields

    private int _totalWaterAmount;

    public int TotalWaterAmount
    {
        get { return _totalWaterAmount; }
        set { _totalWaterAmount = value; OnPropertyChanged(); }
    }

    private int _capacityOfWater;

    public int CapacityOfWater
    {
        get { return _capacityOfWater; }
        set { _capacityOfWater = value; OnPropertyChanged(); }
    }

    private int _currentAmountOfWater;

    public int CurrentAmountOfWater
    {
        get { return _currentAmountOfWater; }
        set { _currentAmountOfWater = value; OnPropertyChanged(); WaterProgressBarState = CalculateCurrentWaterState(); }
    }

    private float _waterProgressBarState;

    public float WaterProgressBarState
    {
        get { return _waterProgressBarState; }
        set { _waterProgressBarState = value; OnPropertyChanged(); }
    }


    #endregion

    #region Days fields

    private int _daysDifference;

    public int DaysDifference
    {
        get { return _daysDifference; }
        set { _daysDifference = value; OnPropertyChanged(); }
    }


    private string _twoDaysAgoText;

    public string TwoDaysAgoText
    {
        get { return _twoDaysAgoText; }
        set { _twoDaysAgoText = value; OnPropertyChanged(); }
    }

    private string _yesterdayText;

    public string YesterdayText
    {
        get { return _yesterdayText; }
        set { _yesterdayText = value; OnPropertyChanged(); }
    }

    private string _todayText;

    public string TodayText
    {
        get { return _todayText; }
        set { _todayText = value; OnPropertyChanged(); }
    }

    private string _tomorrowText;

    public string TomorrowText
    {
        get { return _tomorrowText; }
        set { _tomorrowText = value; OnPropertyChanged(); }
    }

    private string _inTwoDays;

    public string InTwoDays
    {
        get { return _inTwoDays; }
        set { _inTwoDays = value; OnPropertyChanged(); }
    }

    #endregion

    #region Submit fields

    #region Submit limits

    private string _kcalSubmitLimit;

    public string KcalSubmitLimit
    {
        get { return _kcalSubmitLimit; }
        set { _kcalSubmitLimit = "/" + value + " kcal"; OnPropertyChanged(); }
    }

    private string _bSubmitLimit;

    public string BSubmitLimit
    {
        get { return _bSubmitLimit; }
        set { _bSubmitLimit = "/" + value + " g"; OnPropertyChanged(); }
    }

    private string _tSubmitLimit;

    public string TSubmitLimit
    {
        get { return _tSubmitLimit; }
        set { _tSubmitLimit = "/" + value + " g"; OnPropertyChanged(); }
    }

    private string _WSubmitLimit;

    public string WSubmitLimit
    {
        get { return _WSubmitLimit; }
        set { _WSubmitLimit = "/" + value + " g"; OnPropertyChanged(); }
    }

    #endregion

    #region Submit bars fileds

    private float _kcalProgressBarState;

    public float KcalProgressBarState
    {
        get { return _kcalProgressBarState; }
        set { _kcalProgressBarState = value; OnPropertyChanged(); }
    }

    private float _bProgressBarState;

    public float BProgressBarState
    {
        get { return _bProgressBarState; }
        set { _bProgressBarState = value; OnPropertyChanged(); }
    }

    private float _tProgressBarState;

    public float TProgressBarState
    {
        get { return _tProgressBarState; }
        set { _tProgressBarState = value; OnPropertyChanged(); }
    }

    private float _wProgressBarState;

    public float WProgressBarState
    {
        get { return _wProgressBarState; }
        set { _wProgressBarState = value; OnPropertyChanged(); }
    }


    #endregion

    #region Current submit fields

    private int _currentKcalAmount;

    public int CurrentKcalAmount
    {
        get { return _currentKcalAmount; }
        set { _currentKcalAmount = value; OnPropertyChanged(); }
    }

    private int _currentBAmount;

    public int CurrentBAmount
    {
        get { return _currentBAmount; }
        set { _currentBAmount = value; OnPropertyChanged(); }
    }

    private int _currentTAmount;

    public int CurrentTAmount
    {
        get { return _currentTAmount; }
        set { _currentTAmount = value; OnPropertyChanged(); }
    }

    private int _currentWAmount;

    public int CurrentWAmount
    {
        get { return _currentWAmount; }
        set { _currentWAmount = value; OnPropertyChanged(); }
    }


    #endregion

    #endregion

    #region Total macro fields

        #region breakfast

        private string _breakfastBTotalAmount;
        public string BreakfastBTotalAmount
        {
            get { return _breakfastBTotalAmount; }
            set { _breakfastBTotalAmount = value; OnPropertyChanged(); }
        }

        private string _breakfastTTotalAmount;

        public string BreakfastTTotalAmount
        {
            get { return _breakfastTTotalAmount; }
            set { _breakfastTTotalAmount = value; OnPropertyChanged(); }
        }

        private string _breakfastWTotalAmount;

        public string BreakfastWTotalAmount
        {
            get { return _breakfastWTotalAmount; }
            set { _breakfastWTotalAmount = value; OnPropertyChanged(); }
        }

        private string _breakfastKcalTotalAmount;

        public string BreakfastKcalTotalAmount
        {
            get { return _breakfastKcalTotalAmount; }
            set { _breakfastKcalTotalAmount = value; OnPropertyChanged(); }
        }


        #endregion

        #region second breakfast

        private string _secondbreakfastBTotalAmount;

        public string SecondBreakfastBTotalAmount
        {
            get { return _secondbreakfastBTotalAmount; }
            set { _secondbreakfastBTotalAmount = value; OnPropertyChanged(); }
        }

        private string _secondBreakfastTTotalAmount;

        public string SecondBreakfastTTotalAmount
        {
            get { return _secondBreakfastTTotalAmount; }
            set { _secondBreakfastTTotalAmount = value; OnPropertyChanged(); }
        }

        private string _secondBreakfastWTotalAmount;

        public string SecondBreakfastWTotalAmount
        {
            get { return _secondBreakfastWTotalAmount; }
            set { _secondBreakfastWTotalAmount = value; OnPropertyChanged(); }
        }

        private string _secondBreakfastKcalTotalAmount; 

        public string SecondBreakfastKcalTotalAmount
        {
            get { return _secondBreakfastKcalTotalAmount; }
            set { _secondBreakfastKcalTotalAmount = value; OnPropertyChanged(); }
        }


        #endregion

        #region Lunch

        private string _lunchBTotalAmount;

        public string LunchBTotalAmount
        {
            get { return _lunchBTotalAmount; }
            set { _lunchBTotalAmount = value; OnPropertyChanged(); }
        }

        private string _lunchTTotalAmount;

        public string LunchTTotalAmount
        {
            get { return _lunchTTotalAmount; }
            set { _lunchTTotalAmount = value; OnPropertyChanged(); }
        }

        private string _lunchWTotalAmount;

        public string LunchWTotalAmount
        {
            get { return _lunchWTotalAmount; }
            set { _lunchWTotalAmount = value; OnPropertyChanged(); }
        }

        private string _lunchKcalTotalAmount;

        public string LunchKcalTotalAmount
        {
            get { return _lunchKcalTotalAmount; }
            set { _lunchKcalTotalAmount = value; OnPropertyChanged(); }
        }

        #endregion

        #region Dinner

        private string _dinnerBTotalAmount;

        public string DinnerBTotalAmount
        {
            get { return _dinnerBTotalAmount; }
            set { _dinnerBTotalAmount = value; OnPropertyChanged(); }
        }

        private string _dinnerTTotalAmount;

        public string DinnerTTotalAmount
        {
            get { return _dinnerTTotalAmount; }
            set { _dinnerTTotalAmount = value; OnPropertyChanged(); }
        }

        private string _dinnerWTotalAmount;

        public string DinnerWTotalAmount
        {
            get { return _dinnerWTotalAmount; }
            set { _dinnerWTotalAmount = value; OnPropertyChanged(); }
        }

        private string _dinnerKcalTotalAmount;

        public string DinnerKcalTotalAmount
        {
            get { return _dinnerKcalTotalAmount; }
            set { _dinnerKcalTotalAmount = value; OnPropertyChanged(); }
        }

        #endregion

        #region Supper

        private string _supperBTotalAmount;

        public string SupperBTotalAmount
        {
            get { return _supperBTotalAmount; }
            set { _supperBTotalAmount = value; OnPropertyChanged(); }
        }

        private string _supperTTotalAmount;

        public string SupperTTotalAmount
        {
            get { return _supperTTotalAmount; }
            set { _supperTTotalAmount = value; OnPropertyChanged(); }
        }

        private string _supperWTotalAmount;

        public string SupperWTotalAmount
        {
            get { return _supperWTotalAmount; }
            set { _supperWTotalAmount = value; OnPropertyChanged(); }
        }

        private string _supperKcalTotalAmount;

        public string SupperKcalTotalAmount
        {
            get { return _supperKcalTotalAmount; }
            set { _supperKcalTotalAmount = value; OnPropertyChanged(); }
        }

        #endregion

        #endregion

        #endregion
    }
}