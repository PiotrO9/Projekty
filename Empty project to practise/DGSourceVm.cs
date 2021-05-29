using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Empty_project_to_practise
{
    class DGSourceVm : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ICommand ButtonClickCommand { get; set; }

        public DGSourceVm()
        {
            ButtonClickCommand = new RelayCommand(() =>
            {
                ;
            }
            );


            ButtonClickCommand = new RelayCommand(ButtonClickCommandImpl);
        }

        private void ButtonClickCommandImpl()
        {
            item item = new item();
            item.Statement = true;
            item.Text = "Sample";

            _listOfItems.Add(item);
        }


        private List<item> _listOfItems;

        public List<item> ListOfItems
        {
            get { return _listOfItems; }
            set { _listOfItems = value; OnPropertyChanged(); }
        }
    }

    class item
    {
        public string Text { get; set; }

        public bool Statement { get; set; }
    }
}
