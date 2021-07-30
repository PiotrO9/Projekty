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
    /// Logika interakcji dla klasy SingleGPUPage.xaml
    /// </summary>
    public partial class SingleGPUPage : Page
    {
        private ManagementObject _managementObject;

        public SingleGPUPage(ManagementObject managementObject)
        {
            InitializeComponent();
            _managementObject = managementObject;
            FillLabelsByGPU();
        }

        public void FillLabelsByGPU()
        {
            GpuNameLabelOutput.Content = _managementObject["Name"];
            GpuDeviceIdLabelOutput.Content = _managementObject["DeviceID"];
            GpuInstaledDisplayDriversLabelOutput.Content = _managementObject["InstalledDisplayDrivers"];
            GpuDriverVersionLabelOutput.Content = _managementObject["DriverVersion"];
            GpuVideoProcessorLabelOutput.Content = _managementObject["VideoProcessor"];
        }
    }
}
