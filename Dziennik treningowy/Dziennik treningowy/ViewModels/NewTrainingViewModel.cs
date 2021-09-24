using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Dziennik_treningowy.ViewModels
{
    class NewTrainingViewModel
    {

        public NewTrainingViewModel()
        {
            click = new Command(OnClick);
        }

        public ICommand click { get; }

        public async void OnClick()
        {
           await Shell.Current.GoToAsync("..");
        }
    }
}
