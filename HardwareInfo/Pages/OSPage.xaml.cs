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
    /// Logika interakcji dla klasy OSPage.xaml
    /// </summary>
    public partial class OSPage : Page
    {
        public OSPage()
        {
            InitializeComponent();
            GetOSInformation();
        }

        public void GetOSInformation()
        {
            ManagementObjectSearcher myOperativeSystemObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");

            foreach (ManagementObject obj in myOperativeSystemObject.Get())
            {
                OSCaptionLabelOutput.Content = obj["Caption"];
                OSDirectoryLabelOutput.Content = obj["SystemDirectory"];
                OSVersionLabelOutput.Content = obj["Version"];
            }
        }
    }
}
