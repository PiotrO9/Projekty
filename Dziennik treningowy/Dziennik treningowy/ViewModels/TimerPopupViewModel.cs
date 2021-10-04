using Dziennik_treningowy.Views.Popups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Dziennik_treningowy.ViewModels
{
    class TimerPopupViewModel : INotifyPropertyChanged
    {
        private readonly TimerPopup _tp;

        private NewTrainingViewModel _newTrainingViewModel;

        private string _textToDisplay;
        public string TextToDisplay
        {
            get
            {
                return _textToDisplay;
            }
            set
            {
                _textToDisplay = value;
                OnPropertyChanged();
            }
        }

        private int _seconds;


        private string _buttonText;
        public string ButtonText
        {
            get 
            {
                return _buttonText;
            }
            set
            {
                _buttonText = value;
                OnPropertyChanged();
            }
        }


        public TimerPopupViewModel(TimerPopup timerPopup, NewTrainingViewModel newTrainingViewModel,int sec)
        {
            _newTrainingViewModel = newTrainingViewModel;
            _tp = timerPopup;
            _seconds = sec;

            CloseClickCommand = new Command(CloseClickCommandImpl);
            TextToDisplay = sec.ToString();
            ButtonText = "Zacznij";
        }

        public Command CloseClickCommand { get; }

        public void CloseClickCommandImpl()
        {
            if (ButtonText == "Zacznij")
            {
                ButtonText = "Przerwij";
                TimerMethod(_seconds);
            }
            else
            {
            _tp.Dismiss(null);
            }
        }

        public void TimerMethod(int sec)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                int ElapsedTime = (int)stopwatch.Elapsed.TotalSeconds;
                int combine = _seconds - ElapsedTime;

                if (combine == 0)
                {
                    TextToDisplay = combine.ToString();
                    return false;
                }

                TextToDisplay = combine.ToString();
                return true;
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
