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
    class RegisterPageVM : INotifyPropertyChanged
    {
        private MainWindow _mw { get; set; }

        private RegisterPage _rp { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public RegisterPageVM(MainWindow mainWindow,RegisterPage registerPage)
        {
            _mw = mainWindow;
            _rp = registerPage;

            ButtonClickCommand = new RelayCommand(ButtonClickCommandImpl);
        }

        public ICommand ButtonClickCommand { get; set; }

        public void ButtonClickCommandImpl()
        {
            if(CheckIfEmpty.Method(_rp.TypePasswordTxtBox.Text,_rp.ConfirmPasswordTxtBox.Text) == true)
            {
                if(CheckIfEqual.Method(_rp.TypePasswordTxtBox.Text, _rp.ConfirmPasswordTxtBox.Text) == true)
                {
                    if (_rp.TypePasswordTxtBox.Text.Length < 26 && _rp.ConfirmPasswordTxtBox.Text.Length < 26)
                    {
                        UserData userData = new UserData();
                        userData.AccountNumber = int.Parse(_rp.AccountNumberLabelOutput.Content.ToString());
                        userData.Password = _rp.TypePasswordTxtBox.Text;
                        userData.Amount = 0;
                        userData.IsAdmin = false;

                        _mw.db.UserDatas.Add(userData);
                        _mw.db.SaveChanges();

                        _mw.MainFrame.Content = new StartPage(_mw);
                    }
                    else
                    {
                        _rp.ConfirmPasswordTxtBox.Text = string.Empty;
                        _rp.TypePasswordTxtBox.Text = string.Empty;
                    }
                }
            }
            else
            {
                _rp.TypePasswordTxtBox.Text = string.Empty;
                _rp.ConfirmPasswordTxtBox.Text = string.Empty;
            }
        }
    }
}
