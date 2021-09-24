using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace Dziennik_treningowy.Views
{
    class AppShellViewModel : INotifyPropertyChanged
    {
        public AppShellViewModel()
        {
            test = new RelayCommand(testImpl);
        }

        public ICommand test;

        public void testImpl()
        {

        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
