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

        private int _percentsToUse;

        public int PercentsToUse
        {
            get { return _percentsToUse; }
            set { _percentsToUse = value; OnPropertyChanged(); }
        }


        private bool _modifyValuesState;

        public bool ModifyValuesState
        {
            get { return _modifyValuesState; }
            set { _modifyValuesState = value; OnPropertyChanged(); }
        }

        private int _kcalAmount;

        public int KcalAmount
        {
            get { return _kcalAmount; }
            set 
            {
                _kcalAmount = value;
                OnPropertyChanged();
                KcalTextChangedCommand.Execute(this);
                KcalTextChanged(KcalAmount);
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
                UpdatePercentsToUse();
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
                UpdatePercentsToUse();
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
                UpdatePercentsToUse();
            }
        }

        #endregion

        #region Entry

        public Command KcalTextChangedCommand => new Command<int>((t) => KcalTextChanged(t));
        public Command PercentTextChangedCommand => new Command<TypeOfMacro>((t) => PercentTextChanged(t));

        private void PercentTextChanged(TypeOfMacro typeOfMacro)
        {
            if (CheckSumOfPercents())
            {
                switch (typeOfMacro)
                {
                    case TypeOfMacro.B:
                        {
                            break;
                        }
                    case TypeOfMacro.T:
                        break;
                    case TypeOfMacro.W:
                        break;
                    default:
                        break;
                }
            }
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

            if(KcalAmount == 0 && BEntryAmount == 0 && TEntryAmount == 0 && WEntryAmount == 0)
            {
                PercentsToUse = 100;
            }
            else
            {
                PercentsToUse = 0;
            }

            CheckIfKcalIsOver1000();
        }

        private void CheckIfKcalIsOver1000()
        {
            if (KcalAmount >= 1000)
                ModifyValuesState = false;
            else
                ModifyValuesState = true;
        }
        private bool CheckIfSumIs100Percnt()
        {
            int sum = BEntryPercent + TEntryPercent + WEntryPercent;

            if (sum == 100)
                return true;
            else 
                return false;
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

        public void UpdatePercentsToUse()
        {
            int sum = BEntryPercent + TEntryPercent + WEntryPercent;

            if(sum > 100)
            {
                PercentsToUse += sum - 100;
            }

            if(PercentsToUse < 0)
            {
                PercentsToUse += PercentsToUse * -1;
            }
            else
            {
                int calculation = 100 - sum;

                if (calculation >= 0)
                    PercentsToUse = calculation;
                else
                    PercentsToUse = 0;
            }

        }

        #endregion
    }
}
