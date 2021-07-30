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
    /// Logika interakcji dla klasy BIOSPage.xaml
    /// </summary>
    public partial class BIOSPage : Page
    {
        public BIOSPage()
        {
            InitializeComponent();
            GetBiosInformation();
        }

        private void GetBiosInformation()
        {
            SelectQuery Sq = new SelectQuery("Win32_BIOS");
            ManagementObjectSearcher mSearcher = new ManagementObjectSearcher(Sq);
            ManagementObjectCollection collection = mSearcher.Get();

            foreach (ManagementObject obj in collection)
            {
                string relDt = "";

                BiosMakerLabelOutput.Content = (string)obj["Manufacturer"];
                BiosSerialNumberOutput.Content = (string)obj["SerialNumber"];
                BiosVersionLabelOutput.Content = (string)obj["Version"];
                relDt = (string)obj["ReleaseDate"];
                DateTime dt = ManagementDateTimeConverter.ToDateTime(relDt);
                BiosReleaseDateOutput.Content = dt.ToString("dd-MMM-yyyy");//date format
            }
        }
    }
}
