using Dziennik_treningowy.Views;
using Dziennik_treningowy.Views.Popups;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.CommunityToolkit.Extensions;
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
            ExistingTrainingCommand = new RelayCommand(ExistingTrainingCommandImpl);
        }

        #region Commands

        public ICommand NewTrainingCommand { get; }
        public ICommand ExistingTrainingCommand { get; }

        public ICommand RoutineCommand { get; }

        #endregion

        public async void NewTrainingCommandImpl()
        {
            await Shell.Current.GoToAsync(nameof(NewTrainingPage));
        }

        public void ExistingTrainingCommandImpl()
        {

            _startTrainingPage.Navigation.ShowPopup(new PickRoutinePopup
            {
                IsLightDismissEnabled = false
            });

            //await Shell.Current.GoToAsync(nameof(TrainingRoutinePage));
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
