using HardwareInfo.Models.Enums;
using HardwareInfo.Viewmodels;
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

namespace HardwareInfo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ButtonsClickViewModel _vm;

        public CurrentPageEnum currentPageEnum { get; set; }

        public MainWindow()
        {
            currentPageEnum = CurrentPageEnum.none;
            _vm = new ButtonsClickViewModel(this);
            DataContext = _vm;
            InitializeComponent();
        }

        private void BiosButton_Click(object sender, RoutedEventArgs e)
        {
            currentPageEnum = CurrentPageEnum.BIOS;
        }

        private void CpuButton_Click(object sender, RoutedEventArgs e)
        {
            currentPageEnum = CurrentPageEnum.CPU;
        }

        private void MemoryButton_Click(object sender, RoutedEventArgs e)
        {
            currentPageEnum = CurrentPageEnum.MEMORY;
        }

        private void GpuButton_Click(object sender, RoutedEventArgs e)
        {
            currentPageEnum = CurrentPageEnum.GPU;
        }

        private void OsButton_Click(object sender, RoutedEventArgs e)
        {
            currentPageEnum = CurrentPageEnum.OS;
        }

        private void RAMButton_Click(object sender, RoutedEventArgs e)
        {
            currentPageEnum = CurrentPageEnum.RAM;
        }
    }
}
