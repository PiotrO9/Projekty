using Nutrition_App.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Nutrition_App.ViewModels
{
    public class SettingsPageViewModel : BaseViewModel
    {
        public SettingsPageViewModel()
        {
            LoadPreferences();
        }

        #region Fields

        public bool ModifyValuesState { get; set; }

        private int _kcalAmount;

        public int KcalAmount
        {
            get { return _kcalAmount; }
            set 
            {
                _kcalAmount = value;
                OnPropertyChanged();
                KcalTextChangedCommand.Execute(this);
            }
        }

        private int _bEntryAmount;

        public int BEntryAmount
        {
            get { return _bEntryAmount; }
            set
            {
                _bEntryAmount = value;
                OnPropertyChanged();
            }
        }

        private int _bEntryPercent;

        public int BEntryPercent
        {
            get { return _bEntryPercent; }
            set
            {
                _bEntryPercent = value;
                OnPropertyChanged();
            }
        }

        private int _tEntryAmount;

        public int TEntryAmount
        {
            get { return _tEntryAmount; }
            set
            {
                _tEntryAmount = value;
                OnPropertyChanged();
            }
        }

        private int _tEntryPercent;

        public int TEntryPercent
        {
            get { return _tEntryPercent; }
            set
            {
                _tEntryPercent = value;
                OnPropertyChanged();
            }
        }

        private int _wEntryAmount;

        public int WEntryAmount
        {
            get { return _wEntryAmount; }
            set { _wEntryAmount = value; }
        }

        private int _wEntryPercent;

        public int WEntryPercent
        {
            get { return _wEntryPercent; }
            set
            {
                _wEntryPercent = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Entry

        public Command KcalTextChangedCommand => new Command<int>((t) => KcalTextChanged(t));
        public Command PercentTextChangedCommand => new Command<TypeOfMacro>((t) => PercentTextChanged(t));

        private void PercentTextChanged(TypeOfMacro typeOfMacro)
        {
            //if(CheckSumOfPercents())
            //{
            //    switch (typeOfMacro)
            //    {
            //        case TypeOfMacro.B:
            //            {
                            
            //            break;
            //            }
            //        case TypeOfMacro.T:
            //            break;
            //        case TypeOfMacro.W:
            //            break;
            //        default:
            //            break;
            //    }
            //}
        }

        private void KcalTextChanged(int t)
        {
            CheckIfKcalIsOver1000();
        }

        #endregion

        #region Methods

        public void LoadPreferences()
        {
            KcalAmount = int.Parse(Preferences.Get("KcalSubmitLimit", "0"));
            BEntryAmount = int.Parse(Preferences.Get("BSubmitLimit", "0"));
            TEntryAmount = int.Parse(Preferences.Get("TSubmitLimit", "0"));
            WEntryAmount = int.Parse(Preferences.Get("WSubmitLimit", "0"));

            CheckIfKcalIsOver1000();
        }

        private void CheckIfKcalIsOver1000()
        {
            if (KcalAmount >= 1000)
                ModifyValuesState = true;
            else
                ModifyValuesState = false;
        }

        public bool CheckSumOfPercents()// True - suma mniejsza lub równa 100
        {
            if(BEntryPercent >= 100 || TEntryPercent >= 100 || WEntryPercent >= 100)
            {
                return false;
            }

            int sum = BEntryPercent + TEntryPercent + WEntryPercent;

            if (sum > 100)
            {
                return false;
            }

            return true;
        }

        #endregion
    }
}
