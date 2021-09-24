using Dziennik_treningowy.Views;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Dziennik_treningowy.ViewModels
{
    class StartTrainingViewModel : INotifyPropertyChanged
    {
        private StartTrainingPage _startTrainingPage;

        public StartTrainingViewModel(StartTrainingPage startTrainingPage)
        {
            _startTrainingPage = startTrainingPage;
            NewTrainingCommand = new RelayCommand(NewTrainingCommandImpl);
        }

        #region Commands

        public ICommand NewTrainingCommand { get; }

        public ICommand RoutineCommand { get; }

        #endregion

        public async void NewTrainingCommandImpl()
        {
            await Shell.Current.GoToAsync(nameof(NewTrainingPage));
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
