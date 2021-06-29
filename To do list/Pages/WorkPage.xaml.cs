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

        private UserTypeOfSaveChoice userTypeOfSaveChoice;

        public WorkPage(MainPage mainPage) // New page
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

        public WorkPage(string s, MainPage mainPage) // Existing page
        {
            InitializeComponent();
            DataContext = _vm;

            filePath = s;

            ItemsCollection = TXTtoObservableCollection.Method(filePath);

            DataGridView.ItemsSource = ItemsCollection;

            mp = mainPage;
        }

        public WorkPage(string s, MainPage mainPage, string[] text) // Existing page with text
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

        private void Overwrite_Click(object sender, RoutedEventArgs e)
        {
            userTypeOfSaveChoice = UserTypeOfSaveChoice.Overwrite;

            ChoiceListView.Visibility = Visibility.Visible;
            string[] files = Directory.GetFiles("saves");

            if (files.Length == 0)
            {
                MessageBox.Show("List is empty");
            }
            else
            {
                ChoiceListView.ItemsSource = files;
            }
        }
        private bool CheckItemsListContent()
        {
            if (ItemsCollection.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ChoiceListView_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListViewItem;
            if (item != null && item.IsSelected)
            {
                switch (userTypeOfSaveChoice)
                {
                    case UserTypeOfSaveChoice.Copy: //Copy
                        {
                            ChoiceListView.Visibility = Visibility.Hidden;

                            string[] currentPartOfText = TXTtoObservableCollection.ReturnOnlyLines(filePath);
                            string pickedPath = item.DataContext.ToString();
                            string[] pickedPartOfText = TXTtoObservableCollection.ReturnOnlyLines(pickedPath);
                            string[] resultArray = ConnectTwoStringArrays.Method(currentPartOfText, pickedPartOfText);

                            using (StreamWriter sw = File.CreateText(pickedPath))
                            {
                                for (int i = 0; i < resultArray.Length - 1; i++)
                                {
                                    sw.WriteLine(resultArray[i]);
                                }
                                sw.Close();
                            }

                            WorkPage workPage = new WorkPage(pickedPath, mp);

                            workPage.ItemsCollection = TXTtoObservableCollection.Method(pickedPath);

                            mp._mainWindow.Main.Content = workPage;

                            DataGridView.ItemsSource = ItemsCollection;

                            MessageBox.Show("Successfully created new list named: " + pickedPath);

                            break;
                        }
                    case UserTypeOfSaveChoice.Overwrite: // Overwrite
                        {
                            ChoiceListView.Visibility = Visibility.Hidden;
                            string[] currentPartOfText = TXTtoObservableCollection.ReturnOnlyLines(filePath);
                            string pickedPath = item.DataContext.ToString();

                            using (StreamWriter sw = File.CreateText(pickedPath))
                            {
                                for (int i = 0; i < currentPartOfText.Length; i++)
                                {
                                    sw.WriteLine(currentPartOfText[i]);
                                }
                                sw.Close();
                            }

                            WorkPage workPage = new WorkPage(pickedPath, mp);

                            workPage.ItemsCollection = TXTtoObservableCollection.Method(pickedPath);

                            mp._mainWindow.Main.Content = workPage;

                            DataGridView.ItemsSource = ItemsCollection;

                            MessageBox.Show("Successfully created new list named: " + pickedPath);

                            break;
                        }
                }
            }
        }

        private void ExistingFileCopy_Click(object sender, RoutedEventArgs e)
        {
            userTypeOfSaveChoice = UserTypeOfSaveChoice.Copy;

            ChoiceListView.Visibility = Visibility.Visible;
            string[] files = Directory.GetFiles("saves");

            if (files.Length == 0)
            {
                MessageBox.Show("List is empty");
            }
            else
            {
                ChoiceListView.ItemsSource = files;
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
