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
    /// Logika interakcji dla klasy AdminControlPage.xaml
    /// </summary>
    public partial class AdminControlPage : Page
    {
        private MainWindow _mw { get; set; }

        private AdminPage _ap { get; set; }

        private UserData _ud { get; set; }
         

        public AdminControlPage(MainWindow mainWindow, AdminPage adminPage,UserData userData)
        {
            InitializeComponent();
            _mw = mainWindow;
            _ap = adminPage;
            _ud = userData;

            SetDatas();
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            if(CheckIfEmpty.Method(this.AccountPasswordOutput.Text,this.AccountAmountOutput.Text) == true)
            {
                float temp;

                if(float.TryParse(AccountAmountOutput.Text,out temp) == true)
                {
                    UserData tempUserData = (from x in _mw.db.UserDatas
                                             where x.AccountNumber == _ud.AccountNumber
                                             select x).First();

                    tempUserData.Password = this.AccountPasswordOutput.Text;
                    tempUserData.Amount = float.Parse(this.AccountAmountOutput.Text);

                    bool tempBool = this.IsAdminOutput.IsChecked.Value;

                    tempUserData.IsAdmin = tempBool;

                    _mw.db.SaveChanges();

                    _mw.MainFrame.Content = new AdminPage(_mw,_ap.userData);
                    
                }
            }
        }

        private void SetDatas()
        {
            this.AccountNumberLabelOutput.Content = _ud.AccountNumber;
            this.AccountPasswordOutput.Text = _ud.Password;
            this.AccountAmountOutput.Text = _ud.Amount.ToString();
            
            if(_ud.IsAdmin == true)
            {
                this.IsAdminOutput.IsChecked = true;
            }
            else
            {
                this.IsAdminOutput.IsChecked = false;
            }
        }
    }
}
