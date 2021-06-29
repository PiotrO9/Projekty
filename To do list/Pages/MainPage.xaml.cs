using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
using To_do_list.Engines;

namespace To_do_list.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainWindow _mainWindow { get; set; }

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
            _mainWindow.Main.Content = new WorkPage(this);
        }

        private void LoadListButton_Click(object sender, RoutedEventArgs e)
        {
            string[] files = Directory.GetFiles("saves");

            ChoiceListView.Visibility = Visibility.Visible;
            ChoiceListView.ItemsSource = files;
        }

        private void PreviousListButton_Click(object sender, RoutedEventArgs e)
        {
            FileInfo newestFile = GetNewestFile(new DirectoryInfo("saves"));

            if (newestFile != null)
            {
                _mainWindow.Main.Content = new WorkPage("saves/" + newestFile.Name, this);
            }
        }
        public static FileInfo GetNewestFile(DirectoryInfo directory)
        {
            return directory.GetFiles()
                .Union(directory.GetDirectories().Select(d => GetNewestFile(d)))
                .OrderByDescending(f => (f == null ? DateTime.MinValue : f.LastWriteTime))
                .FirstOrDefault();
        }

        private void ChoiceListView_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {      
            var item = sender as ListViewItem;
            if (item != null && item.IsSelected)
            {   
                _mainWindow.Main.Content = new WorkPage(item.DataContext.ToString(),this);
            }
        }
    }
}
