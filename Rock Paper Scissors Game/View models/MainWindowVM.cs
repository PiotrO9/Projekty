using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Rock_Paper_Scissors_Game.View_models
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private string _displayText = "Start";

        public string DisplayText
        {
            get { return _displayText; }
            set { _displayText = value; OnPropertyChanged(); }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ICommand ButtonClickCommand { get; set; }

        public MainWindowVM()
        {
            ButtonClickCommand = new RelayCommand(ButtonNumberClickCommandImpl);
        }

        public void ButtonNumberClickCommandImpl()
        {
            DisplayText = "1";
        }
    }

}


