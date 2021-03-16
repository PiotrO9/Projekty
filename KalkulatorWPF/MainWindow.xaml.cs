using KalkulatorWPF.Engines;
using KalkulatorWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KalkulatorWPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainWindowVM _vm = new MainWindowVM();

        MainTextClass MainText = new MainTextClass();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _vm;
        }

        public void Btn_Clicked(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;

            switch (clickedButton.Content)
            {
                case '+':
                    {
                        LockActions();
                        break;
                    }
                case '-':
                    {
                        LockActions();
                        break;
                    }
                case '*':
                    {
                        LockActions();
                        break;
                    }
                case '/':
                    {
                        LockActions();
                        break;
                    }
                default:
                    {
                        MainTxtBox.Text += clickedButton.Content;
                    }
                    break;
            }

            MainTxtBox.Text += clickedButton.Content;

        }

        public void LockActions()
        {
            if (AddBtn.IsEnabled == false)
            {
                SubBtn.IsEnabled = false;
            }
            else
            {
                AddBtn.IsEnabled = true;
                MulBtn.IsEnabled = true;
                DivBtn.IsEnabled = true;
            }
        }

        public void UnlockActions()
        {
            AddBtn.IsEnabled = true;
            SubBtn.IsEnabled = true;
            MulBtn.IsEnabled = true;
            DivBtn.IsEnabled = true;
        }

    }
}
