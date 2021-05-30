using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private ObservableCollection<item> ItemsCollection;

        public WorkPage()
        {
            InitializeComponent();
            DataContext = _vm;

            ItemsCollection = new ObservableCollection<item>();

            DataGridView.ItemsSource = ItemsCollection;

            int n = DataGridView.Columns.Count;
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            string temporaryText = TextBox.Text;

            bool temporaryBool = false;

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

                int n = DataGridView.Columns.Count;

                if (DataGridView.Columns.Count > 0)
                {
                    DataGridView.Columns[0].IsReadOnly = true;
                }

                TextBox.Text = "";
            }

        }


        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            item selectedItem = (item)DataGridView.SelectedItem;

            if(selectedItem != null)
            {
                ItemsCollection = ChangeOrder.Method(ItemsCollection, selectedItem, Direction.UP);
            }
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            item selectedItem = (item)DataGridView.SelectedItem;

            if (selectedItem != null)
            {
                ItemsCollection = ChangeOrder.Method(ItemsCollection, selectedItem, Direction.DOWN);
            }
        }
    }
}
