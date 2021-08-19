using Bank_application.services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logika interakcji dla klasy AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        private MainWindow _mw { get; set; }

        public UserData userData { get; set; }

        private List<UserData> ItemsCollection;

        public AdminPage(MainWindow mainWindow,UserData ud)
        {
            InitializeComponent();
            _mw = mainWindow;
            userData = ud;

            ContextDb db = _mw.db;

            SetDatas();
            //this.MainListView.ItemsSource = ItemsCollection;
            this.MainDataGrid.ItemsSource = ItemsCollection;
            
        }

        private void SetDatas()
        {
            this.AccountNumberLabelOutput.Content = userData.AccountNumber;
            this.AccountPasswordOutput.Content = userData.Password;
            this.AccountAmountOutput.Content = userData.Amount;

            ItemsCollection = GetDatasCollection.Method(_mw);
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(this.MainDataGrid.SelectedItems.Count != 0)
            {
                UserData userData = this.MainDataGrid.SelectedItem as UserData;

                if (userData.IsAdmin == false)
                {
                    _mw.MainFrame.Content = new AdminControlPage(_mw, this, userData);
                }
            }
        }

        private void MainListView_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
