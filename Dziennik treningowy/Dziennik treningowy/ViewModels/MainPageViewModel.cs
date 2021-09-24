using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Dziennik_treningowy.ViewModels
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            SettingsClick = new Command(SettingsClickImpl);
            HistoryClick = new RelayCommand(HistoryClickImpl);
            TrainingClick = new RelayCommand(TrainingClickImpl);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public Command SettingsClick { get; set; }

        public ICommand HistoryClick { get; set; }

        public ICommand TrainingClick { get; set; }

        public void SettingsClickImpl()
        {

        }

        public void HistoryClickImpl()
        {

        }

        public void TrainingClickImpl()
        {

        }

        #region INotifyPropertyChanged

        #endregion
    }
}
