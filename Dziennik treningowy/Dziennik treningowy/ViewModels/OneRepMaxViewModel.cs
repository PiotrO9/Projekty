using Dziennik_treningowy.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.CommunityToolkit.Extensions;

namespace Dziennik_treningowy.ViewModels
{
    class OneRepMaxViewModel : INotifyPropertyChanged
    {
        private OneRepPage _oneRepPage;

        #region

        private string _bodyWeight;
        public string BodyWeight 
        { 
            get { return _bodyWeight; }
            set
            {
                _bodyWeight = value;
                OnPropertyChanged();
            }
        }

        private string _weight;
        public string Weight 
        {
            get { return _weight; }
            set
            {
                _weight = value;
                OnPropertyChanged();
            }
        }

        private int _reps;
        public int Reps 
        {
            get { return _reps; }
            set 
            {
                _reps = value;
                OnPropertyChanged();
            }
        }

        #endregion

        public OneRepMaxViewModel(OneRepPage oneRepPage)
        {
            _oneRepPage = oneRepPage;

            CalculateCommand = new Command(CalculateCommandImpl);
            QuitCommand = new Command(QuitCommandImpl);
        }

        #region Commands

        public Command CalculateCommand { get; }

        public Command QuitCommand { get; }

       

        #endregion

        #region Commands implementations

        public async void CalculateCommandImpl()
        {
            float bw = 0.0F;
            float w = 0.0F;
            int reps = 0;

            float result = 0.0F;

            if((float.TryParse(BodyWeight,out bw) == true) && (float.TryParse(Weight,out w)==true))
            {
                if(Reps > 12)
                {
                    reps = 12;
                }
                else
                {
                    reps = Reps;
                }

                switch (reps)
                {

                    case 1:
                        {
                            result = w;
                            break;
                        }
                    case 2:
                        {
                            result = w * 1.029F;
                            break;
                        }
                    case 3:
                        {
                            result = w * 1.059F;
                            break;
                        }
                    case 4:
                        {
                            result = w * 1.091F;
                            break;
                        }
                    case 5:
                        {
                            result = w * 1.125F;
                            break;
                        }
                    case 6:
                        {
                            result = w * 1.161F;
                            break;
                        }
                    case 7:
                        {
                            result = w * 1.2F;
                            break;
                        }
                    case 8:
                        {
                            result = w * 1.242F;
                            break;
                        }
                    case 9:
                        {
                            result = w * 1.288F;
                            break;
                        }
                    case 10:
                        {
                            result = w * 1.333F;
                            break;
                        }
                    case 11:
                        {
                            result = w * 1.367F;
                            break;
                        }
                    case 12:
                        {
                            result = w * 1.4F;
                            break;
                        }
                    default:
                        {
                            await _oneRepPage.DisplayToastAsync("Wprowadź prawidłowe dane");
                            break;
                        }
                }

                if(result != 0)
                    await _oneRepPage.DisplayToastAsync("Twój wynik to: " + result);

            }
            else
            {
            await _oneRepPage.DisplayToastAsync("Wprowadź prawidłowe dane");
            }

        }

        public void QuitCommandImpl()
        {

        }

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
