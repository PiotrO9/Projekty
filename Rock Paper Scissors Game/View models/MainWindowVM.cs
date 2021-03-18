using GalaSoft.MvvmLight.Command;
using Rock_Paper_Scissors_Game.Engines;
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

        private string _imagePathOfFirstPicture;

        public string ImagePathOfFirstPicture
        {
            get { return _imagePathOfFirstPicture; }
            set { _imagePathOfFirstPicture = value; OnPropertyChanged(); }
        }

        private string _imagePathOfSecondPicture;

        public string ImagePathOfSecondPicture
        {
            get { return _imagePathOfSecondPicture; }
            set { _imagePathOfSecondPicture = value; OnPropertyChanged(); }
        }

        private bool _isMainWindowEnabled = true;

        public bool IsMainWindowEnabled
        {
            get { return _isMainWindowEnabled; }
            set { _isMainWindowEnabled = value; OnPropertyChanged(); }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ICommand ButtonClickCommand { get; set; }

        public ICommand RandomImageGenerate { get; set; }

        public ICommand ImageClickCommand { get; set; }

        public MainWindowVM(int n1, int n2)
        {
            ImagePathOfFirstPicture = SetCorrectPath.SetCorrectPathFunc(n1);
            ImagePathOfSecondPicture = SetCorrectPath.SetCorrectPathFunc(n2);

            ButtonClickCommand = new RelayCommand(ButtonNumberClickCommandImpl);

            RandomImageGenerate = new RelayCommand(RandomImageGenerateImpl);

            ImageClickCommand = new RelayCommand(ImageClickCommandImpl);
        }

        public void ButtonNumberClickCommandImpl()
        {
            DisplayText = "Pick";

            switch (ImagePathOfSecondPicture)
            {
                case "images/paper.PNG":
                    {
                        ImagePathOfSecondPicture = "images/Cpaper.PNG";
                        break;
                    }
                case "images/Rock.PNG":
                    {
                        ImagePathOfSecondPicture = "images/Crock.PNG";
                        break;
                    }
                case "images/Scissors.PNG":
                    {
                        ImagePathOfSecondPicture = "images/Cscissors.PNG";
                        break;
                    }
                default:
                    break;
            }
        }
        public void RandomImageGenerateImpl()
        {
            Random rn = new Random();
            int randomNumber = rn.Next(1, 3);

            ImagePathOfFirstPicture = SetCorrectPath.SetCorrectPathFunc(randomNumber);

            ImagePathOfSecondPicture = SetCorrectPath.SetCorrectPathFunc(randomNumber);
        }

        public void ImageClickCommandImpl()
        {
            ImagePathOfFirstPicture = "images/Crock.PNG";
        }

    }

}


