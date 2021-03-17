using GalaSoft.MvvmLight.Command;
using KalkulatorWPF.Engines;
using KalkulatorWPF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KalkulatorWPF
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private string buttonName;
        public string ButtonName
        {
            get { return buttonName; }
            set { buttonName = value; OnPropertyChanged(); }
        }

        private string mainText;

        public string MainText
        {
            get { return mainText; }
            set { mainText = value; OnPropertyChanged(); }
        }

        private bool btnAddStatement = true;

        public bool BtnAddStatement
        {
            get { return btnAddStatement; }
            set { btnAddStatement = value; OnPropertyChanged(); }
        }

        private bool btnSubStatement = true;

        public bool BtnSubStatement
        {
            get { return btnSubStatement; }
            set { btnSubStatement = value; OnPropertyChanged(); }
        }

        private bool btnMulStatement = true;

        public bool BtnMulStatement
        {
            get { return btnMulStatement; }
            set { btnMulStatement = value; OnPropertyChanged(); }
        }

        private bool btnDivStatement = true;

        public bool BtnDivStatement
        {
            get { return btnDivStatement; }
            set { btnDivStatement = value; OnPropertyChanged(); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ICommand ButtonClickCommand { get; set; }

        public ICommand ButtonNumberClickCommand { get; set; }

        public MainWindowVM()
        {
            ButtonClickCommand = new RelayCommand(() =>
            {
                ;
            }
            );


            ButtonNumberClickCommand = new RelayCommand<string>(ButtonNumberClickCommandImpl);
        }

        public void ButtonNumberClickCommandImpl(string s)
        {
            string temp = MainText;

            switch (s)
            {
                case "C":
                    {
                        MainText = string.Empty;
                        ButtonUnlock();
                        break;
                    }
                case "+":
                    {
                        if ((CheckIfAction.SearchAction(GetCurrentText()) == false))
                            {
                            
                            MainText += "+";
                            ButtonLock();
                        }
                        else
                        {
                            EqualCalculation();
                            MainText += "+";
                        }


                        break;
                    }
                case "-":
                    {
                        if ((CheckIfAction.SearchAction(GetCurrentText()) == false))
                        {
                            MainText += "-";
                            ButtonLock();
                        }
                        else
                        {
                            EqualCalculation();
                            MainText += "-";
                        }
                        break;
                    }
                case "*":
                    {
                        if ((CheckIfAction.SearchAction(GetCurrentText()) == false))
                        {
                            MainText += "*";
                            ButtonLock();
                        }
                        else
                        {
                            EqualCalculation();
                            MainText += "*";
                        }
                        break;
                    }
                case "/":
                    {
                        if ((CheckIfAction.SearchAction(GetCurrentText()) == false))
                        {
                            MainText += "/";
                            ButtonLock();
                        }
                        else
                        {
                            EqualCalculation();
                            MainText += "/";
                        }
                        break;
                    }
                case "=":
                    {
                        EqualCalculation();
                        break;
                    }
                default:
                    {
                        MainText += s;
                        ButtonUnlock();
                    }
                    break;
            }
        }

        public void ButtonLock()
        {
            if (BtnAddStatement == false)
            {
                BtnSubStatement = false;
            }
            else
            {
                BtnAddStatement = false;
                BtnMulStatement = false;
                BtnDivStatement = false;
            }
        }

        public void ButtonUnlock()
        {
            BtnAddStatement = true;
            BtnSubStatement = true;
            BtnMulStatement = true;
            BtnDivStatement = true;
        }

        public string GetCurrentText()
        {
            string temp = MainText;

            return temp;
        }

        public void EqualCalculation()
        {
            var Result = Calculations.Calculate(MainText);

            if (Result.IsZero == true)
            {
                MainText = " ";
            }
            else
            {
                MainText = Result.Result.ToString();
            }
        }
    }
}
