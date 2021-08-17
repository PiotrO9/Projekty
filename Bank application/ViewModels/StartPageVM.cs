using Bank_application.Pages;
using Bank_application.services;
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
    class StartPageVM : INotifyPropertyChanged
    {
        private MainWindow _mw { get; set; }

        private StartPage _sp { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #region #ctor 

        public StartPageVM(MainWindow mainWindow,StartPage startPage)
        {
            _mw = mainWindow;
            _sp = startPage;

            RegisterClickCommand = new RelayCommand((RegisterClickCommandImpl));

            LoginClickCommand = new RelayCommand((LoginClickCommandImpl));

            ForgotPasswordClickCommand = new RelayCommand((ForgotPasswordClickCommandImpl));
        }

        #endregion

        #region #ICommand
        public ICommand RegisterClickCommand { get; set; }

        public ICommand LoginClickCommand { get; set; }

        public ICommand ForgotPasswordClickCommand { get; set; }

        #endregion

        #region #Impl
        public void RegisterClickCommandImpl()
        {
            _mw.MainFrame.Content = new RegisterPage(_mw); 
        }

        public void LoginClickCommandImpl()
        {
            if(CheckIfEmpty.Method(_sp.AccountNumberTextBox.Text, _sp.PasswordTextBox.Text) == true)
            {
                int temp = int.Parse(_sp.AccountNumberTextBox.Text);

                UserData userData = _mw.db.UserDatas.Where(w => w.AccountNumber == (temp)).Where(w => w.Password == _sp.PasswordTextBox.Text).First();

                if(userData != null && userData.IsAdmin == false)
                {
                    _mw.MainFrame.Content = new UserPage(userData,_mw);
                }
            }
        }
        public void ForgotPasswordClickCommandImpl()
        {
            if (_sp.AccountNumberTextBox.Text != string.Empty)
            {
                UserData userData;

                int temp = int.Parse(_sp.AccountNumberTextBox.Text);

                userData = _mw.db.UserDatas.Where(w => w.AccountNumber == temp).First();

                if(userData != null)
                {
                    _mw.MainFrame.Content = new ForgotPasswordPage(_mw, userData);
                }
            }
        }
        #endregion
    }
}
