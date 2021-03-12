using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    public class MainWindoVM : INotifyPropertyChanged
    {
        private string buttonName;
        public string ButtonName
        {
            get { return buttonName; }
            set { buttonName = value; OnPropertyChanged(); }
        }

        public ICommand ButtonClickCommand { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public MainWindoVM()
        {
            ButtonClickCommand = new RelayCommand(() => ButtonName = "Nowy button");
        }

        public void ButtonClickICommandImpl()
        {

        }







    }
}
