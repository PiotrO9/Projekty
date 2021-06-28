using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Xml.Linq;
using To_do_list.Engines;
using To_do_list.Models;
using To_do_list.Viewmodels;

namespace To_do_list.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy WorkPage.xaml
    /// </summary>
    public partial class WorkPage : Page
    {
        private readonly MainDataGridVM _vm = new MainDataGridVM();

        private MainPage mp;

        private ObservableCollection<item> ItemsCollection;

        private string filePath;

        public WorkPage(MainPage mainPage)
        {
            InitializeComponent();
            DataContext = _vm;

            filePath = "saves/" + CreateFileName.Method() + ".txt";

            StreamWriter sw = File.CreateText(filePath);
            sw.Close();

            ItemsCollection = TXTtoObservableCollection.Method(filePath);

            DataGridView.ItemsSource = ItemsCollection;

            mp = mainPage;
        }

        public WorkPage(string s, MainPage mainPage)
        {
            InitializeComponent();
            DataContext = _vm;

            filePath = s;

            ItemsCollection = TXTtoObservableCollection.Method(filePath);

            DataGridView.ItemsSource = ItemsCollection;

            mp = mainPage;
        }

        public WorkPage(string s, MainPage mainPage, string[] text)
        {
            InitializeComponent();
            DataContext = _vm;

            filePath = s;

            StreamWriter sw = File.CreateText(filePath);
            sw.Close();

            ItemsCollection = TXTtoObservableCollection.fillingMethod(text);

            DataGridView.ItemsSource = ItemsCollection;

            mp = mainPage;
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            DataGridView.ItemsSource = ItemsCollection;

            string temporaryText = TextBox.Text;

            bool temporaryBool = false; // true - adding blocked

            if(temporaryText == "")
            {
                temporaryBool = true;
            }

            int length = temporaryText.Length;

            for (int i = 0; i < length; i++)
            {
                if(temporaryText[i] == ';')
                {
                    temporaryBool = true;
                    break;
                }
            }

            foreach (var item in ItemsCollection)
            {
                if (item.Text == temporaryText)
                {
                    temporaryBool = true;
                }
            }

            if (temporaryBool == false)
            {
                ItemsCollection.Add(new item() { Statement = false, Text = TextBox.Text });

                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.Write(ObservableCollectionToTXT.Method(ItemsCollection));
                    sw.Close();
                }

                int n = DataGridView.Columns.Count;

                if (DataGridView.Columns.Count > 0)
                {
                    DataGridView.Columns[0].IsReadOnly = true;
                }

                TextBox.Text = "";
            }
            else
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.Write(ObservableCollectionToTXT.Method(ItemsCollection));
                    sw.Close();
                }
            }

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            item selectedItem = (item)DataGridView.SelectedItem;

            if (selectedItem != null)
            {
                foreach (var item in ItemsCollection)
                {
                    if (item.Text == selectedItem.Text)
                    {
                        ItemsCollection.Remove(item);
                        break;
                    }
                }
            }
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            item selectedItem = (item)DataGridView.SelectedItem;

            if(selectedItem != null)
            {
                ItemsCollection = ChangeOrder.Method(ItemsCollection, selectedItem, Direction.UP);
            }

            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.Write(ObservableCollectionToTXT.Method(ItemsCollection));
                sw.Close();
            }
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            item selectedItem = (item)DataGridView.SelectedItem;

            if (selectedItem != null)
            {
                ItemsCollection = ChangeOrder.Method(ItemsCollection, selectedItem, Direction.DOWN);
            }

            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.Write(ObservableCollectionToTXT.Method(ItemsCollection));
                sw.Close();
            }
        }

        private void NewFileCopy_Click(object sender, RoutedEventArgs e)
        {
            if(CheckItemsListContent() == false)
            {
                MessageBox.Show("List is empty");
            }
            else
            {
                string[] tempText = TXTtoObservableCollection.ReturnOnlyLines(filePath);
                string tempName = CreateFileName.Method();

                string tempPath = "saves/" + tempName + ".txt";

                WorkPage workPage = new WorkPage(tempPath, mp, tempText);

                workPage.ItemsCollection = TXTtoObservableCollection.fillingMethod(tempText);

                mp._mainWindow.Main.Content = workPage;

                string textToFile = ObservableCollectionToTXT.Method(workPage.ItemsCollection);

                using (StreamWriter sw = File.CreateText(tempPath))
                {
                    sw.Write(textToFile);
                    sw.Close();
                }
                
                DataGridView.ItemsSource = ItemsCollection;


                MessageBox.Show("Successfully created new list named: " + tempName);
            }
        }

        private bool CheckItemsListContent()
        {
            if(ItemsCollection.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
