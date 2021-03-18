using Rock_Paper_Scissors_Game.View_models;
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

namespace Rock_Paper_Scissors_Game
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random rnd = new Random();

        static int n1 = rnd.Next(1, 4);
        static int n2 = rnd.Next(1, 4);

        private readonly MainWindowVM _vm = new MainWindowVM(n1, n2);

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _vm;
        }
    }
}
