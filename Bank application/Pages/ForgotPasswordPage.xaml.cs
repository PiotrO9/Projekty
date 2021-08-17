using Bank_application.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bank_application.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy ForgotPasswordPage.xaml
    /// </summary>
    public partial class ForgotPasswordPage : Page
    {
        private MainWindow _mw { get; set; }

        private UserData _userData { get; set; }

        public ForgotPasswordPage(MainWindow mainWindow,UserData userData)
        {
            InitializeComponent();
            _mw = mainWindow;
            _userData = userData;
        }

        private void btnMain_Click(object sender, RoutedEventArgs e)
        {
            if(CheckIfEmpty.Method(this.TypePasswordTxtBox.Text,this.ConfirmPasswordTxtBox.Text) == true && CheckIfEqual.Method(this.TypePasswordTxtBox.Text, this.ConfirmPasswordTxtBox.Text) == true)
            {
                UserData tempUserData = (from x in _mw.db.UserDatas
                            where x.AccountNumber == _userData.AccountNumber
                            select x).First();

                tempUserData.Password = this.ConfirmPasswordTxtBox.Text;
                _mw.db.SaveChanges();
                _mw.MainFrame.Content = new StartPage(_mw);
            }
            else
            {
                this.TypePasswordTxtBox.Text = string.Empty;
                this.ConfirmPasswordTxtBox.Text = string.Empty;
            }

        }
    }
}
