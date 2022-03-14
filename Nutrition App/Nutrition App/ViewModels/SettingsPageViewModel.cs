using Nutrition_App.Enums;
using Nutrition_App.Services;
using Nutrition_App.Views;
using Nutrition_App.Views.Popups;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Nutrition_App.ViewModels
{
    public class SettingsPageViewModel : BaseViewModel
    {
        public SettingsPageViewModel(SettingsPage settingsPage)
        {
            _sp = settingsPage;
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
                PercentBTextChangedCommand.Execute(BEntryPercent);
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
                PercentTTextChangedCommand.Execute(TEntryPercent);
            }
        }

        private int _wEntryAmount;

        public int WEntryAmount
        {
            get { return _wEntryAmount; }
            set { _wEntryAmount = value;OnPropertyChanged(); }
        }

        private int _wEntryPercent;

        public int WEntryPercent
        {
            get { return _wEntryPercent; }
            set
            {
                _wEntryPercent = value;
                OnPropertyChanged();
                PercentWTextChangedCommand.Execute(WEntryPercent);
            }
        }

        #endregion

        private SettingsPage _sp { get; set; }

        #region Entry

        public Command KcalTextChangedCommand => new Command<int>((t) => KcalTextChanged(t));
        public Command PercentBTextChangedCommand => new Command<int>((t) => PercentBTextChanged(t));
        public Command PercentTTextChangedCommand => new Command<int>((t) => PercentTTextChanged(t));
        public Command PercentWTextChangedCommand => new Command<int>((t) => PercentWTextChanged(t));

        private void PercentBTextChanged(int number)
        {
            if(number > 100)
            {
                number = 100;
            }

            if(PercentsToUse >= 0)
            {
                if (number > PercentsToUse)
                {
                    BEntryPercent = PercentsToUse;
                    PercentsToUse = 0;
                }
                else
                    PercentsToUse -= number;
            }
            UpdatePercentsToUse();
            CalculateKcalFromPercentMacros();
            SaveToPreferences();
        }
        private void PercentTTextChanged(int number)
        {
            if (number > 100)
            {
                //TEntryPercent = PercentsToUse + (TEntryPercent - 100);
                TEntryPercent -= 100;
                //PercentsToUse += TEntryAmount - 100;
            }

            if (PercentsToUse >= 0)
            {
                if (number > PercentsToUse)
                {
                    TEntryPercent = PercentsToUse;
                    PercentsToUse = 0;
                }
                else
                    PercentsToUse -= number;
            }
            UpdatePercentsToUse();
            CalculateKcalFromPercentMacros();
            SaveToPreferences();
        }
        private void PercentWTextChanged(int number)
        {
            if (number > 100)
            {
                number = 100;
            }

            if (PercentsToUse >= 0)
            {
                if (number > PercentsToUse)
                {
                    WEntryPercent = PercentsToUse;
                    PercentsToUse = 0;
                }
                else
                    PercentsToUse -= number;
            }
            UpdatePercentsToUse();
            CalculateKcalFromPercentMacros();
            SaveToPreferences();
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

        public void UpdatePercentsToUse()
        {
            int sum = BEntryPercent + TEntryPercent + WEntryPercent;

            PercentsToUse = 100 - sum;
        }

        public void CalculateKcalFromPercentMacros()
        {
            BEntryAmount = (KcalAmount / 100 * BEntryPercent) / 4;
            TEntryAmount = (KcalAmount / 100 * TEntryPercent) / 9;
            WEntryAmount = (KcalAmount / 100 * WEntryPercent) / 4;
        }
        public bool CheckIfPercentEntriesEqual100()//True jeżeli wartości łącznie dają 100%
        {
            int sum = BEntryPercent + TEntryPercent + WEntryPercent;

            if(BEntryPercent != 0 && TEntryPercent != 0 && WEntryPercent != 0)
            {
                if (sum == 100)
                    return true;
            }
            
            return false;
        }

        public void SaveToPreferences()
        {
            if(CheckIfPercentEntriesEqual100())
            {
                int sum = (BEntryAmount * 4) + (TEntryAmount * 9) + (WEntryAmount * 4);

                Preferences.Set("KcalSubmitLimit", sum.ToString());
                Preferences.Set("BSubmitLimit", BEntryAmount.ToString());
                Preferences.Set("TSubmitLimit", TEntryAmount.ToString());
                Preferences.Set("WSubmitLimit", WEntryAmount.ToString());

                _sp.Navigation.ShowPopup(new MacrosInfoPopup(CombineMacrosTextToDisplay.CombineMacrosTextToDisplayMethod(BEntryAmount,TEntryAmount,WEntryAmount)));
            }
        }

        #endregion
    }
}
