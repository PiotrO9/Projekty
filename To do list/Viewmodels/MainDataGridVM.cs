using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;
using To_do_list.Models;

namespace To_do_list.Viewmodels
{
    class MainDataGridVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; // base

        protected void OnPropertyChanged([CallerMemberName] string name = null) // base
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private ItemsControl _ic = new ItemsControl();

        public ItemsControl ItemsControl
        {
            get { return _ic; }
            set { _ic = value; OnPropertyChanged(); }
        }

        public ObservableCollection<item> ItemsCollection = new ObservableCollection<item>();


        public ICommand ButtonClickCommand { get; set; } //base command

        private List<item> _listOfItems = new List<item>();

        public List<item> ListOfItems
        {
            get { return _listOfItems; }
            set { _listOfItems = value; OnPropertyChanged(); }
        }

        public MainDataGridVM() //ctor
        {
            ButtonClickCommand = new RelayCommand(ButtonClickCommandImpl);
            ItemsControl.ItemsSource = ItemsCollection;
        }

        public void ButtonClickCommandImpl()
        {
            item item = new item();
            item.Statement = true;
            item.Text = "Test";

            ItemsCollection.Add(item);

        }
    }
}
