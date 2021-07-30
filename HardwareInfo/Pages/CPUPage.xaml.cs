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
    /// Logika interakcji dla klasy CPUPage.xaml
    /// </summary>
    public partial class CPUPage : Page
    {
        public CPUPage()
        {
            InitializeComponent();
            GetCPUInformation();
        }

        public void GetCPUInformation()
        {
            ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");

            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                CpuNameLabelOutput.Content = obj["Name"];
                CpuCaptionLabelOutput.Content = obj["Caption"];
                CpuManufacturerLabelOutput.Content = obj["Manufacturer"];
                CpuCoreAmountLabelOutput.Content = obj["NumberOfCores"];
            }
        }
    }
}
