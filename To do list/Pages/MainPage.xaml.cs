using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace To_do_list.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private MainWindow _mainWindow { get; set; }

        public MainPage(MainWindow MW)
        {
            InitializeComponent();
            MW.Main.Content = new MainPage();
            _mainWindow = MW;
        }

        public MainPage()
        {

        }

        private void NewListButton_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.Main.Content = new WorkPage();
        }

        private void LoadListButton_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.Main.Content = new WorkPage();
        }

        private void PreviousListButton_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.Main.Content = new WorkPage();
        }
    }
}
