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
    /// Logika interakcji dla klasy StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        private MainWindow _mw;

        private StartPageVM _startPageVM;
        public StartPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mw = mainWindow;
            _startPageVM = new StartPageVM(_mw,this);
            this.DataContext = _startPageVM;
        }
    }
}
