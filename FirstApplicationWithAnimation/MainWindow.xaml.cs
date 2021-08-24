using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
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

namespace FirstApplicationWithAnimation
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Timer timer { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            SystemSounds.Asterisk.Play();
            
        }

        
    }
}
