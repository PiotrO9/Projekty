using Bank_application.ViewModels;
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
    /// Logika interakcji dla klasy UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        private MainWindow _mw;

        private UserPageVM _vm { get; set; }

        private UserData _userdata{ get; set; }

        public UserPage(UserData userData,MainWindow mainWindow)
        {
            InitializeComponent();
            _userdata = userData;
            _mw = mainWindow;
            _vm = new UserPageVM(_mw,this);
            this.DataContext = _vm;
            SetDatas();
        }

        public void SetDatas()
        {
            this.AccountNumberLabelOutput.Content = _userdata.AccountNumber;
            this.AccountPasswordOutput.Content = _userdata.Password;
            this.AccountAmountOutput.Content = _userdata.Amount;
        }
    }
}
