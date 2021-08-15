using Bank_application.Pages;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Bank_application.ViewModels
{
    class UserPageVM : INotifyPropertyChanged
    {
        private MainWindow _mw { get; set; }

        private UserPage _up { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public UserPageVM(MainWindow mainWindow,UserPage userPage)
        {
            _mw = mainWindow;
            _up = userPage;

            CashOutClickCommand = new RelayCommand(CashOutClickCommandImpl);
            LogoutClickCommand = new RelayCommand(LogoutClickCommandImpl);
        }

        public ICommand CashOutClickCommand { get; set; }

        public ICommand LogoutClickCommand { get; set; }

        public void CashOutClickCommandImpl()
        {

        }

        public void LogoutClickCommandImpl()
        {
            _mw.MainFrame.Content = new StartPage(_mw);
        }
    }
}
