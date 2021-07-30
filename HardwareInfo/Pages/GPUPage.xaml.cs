using HardwareInfo.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
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

namespace HardwareInfo.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy GPUPage.xaml
    /// </summary>
    public partial class GPUPage : Page
    {
        private ManagementObjectSearcher _myVideoObject;

        private int _VideoObejctsAmount;

        private int _CurrentVideoObject;

        private List<ManagementObject> ListOfGPUs;

        public GPUPage()
        {
            InitializeComponent();
            _myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");
            _VideoObejctsAmount = _myVideoObject.Get().Count;

            if (_VideoObejctsAmount != 0)
            {
                _CurrentVideoObject = 1;
            }

            ListOfGPUs = FillGpuList.Method(_myVideoObject);

            if(ListOfGPUs.Count > 0)
            {
                MainFrame.Content = new SingleGPUPage(ListOfGPUs[_CurrentVideoObject]);
            }
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            if(_CurrentVideoObject > 1)
            {
                _CurrentVideoObject -= 1;
                MainFrame.Content = new SingleGPUPage(ListOfGPUs[_CurrentVideoObject - 1]);
            }
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            if(_CurrentVideoObject < _VideoObejctsAmount)
            {
                _CurrentVideoObject += 1;
                MainFrame.Content = new SingleGPUPage(ListOfGPUs[_CurrentVideoObject - 1]);
            }
        }
    }
}
