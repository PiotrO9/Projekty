using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
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

namespace RoundProgressBarAplication
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

        PerformanceCounter cpuCounter;
        PerformanceCounter ramCounter;

        public MainWindow()
        {
            InitializeComponent();

            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            #region #RAM
            var RamAmount = GetRAMInformation();
            int RamUsage = (int)Math.Round(RamAmount -  float.Parse(getAvailableRAM()));
            int PercentRamUsage = (int)Math.Round((RamUsage / RamAmount) * 100);
            Arc1Outputlbl.Content = PercentRamUsage.ToString() + "%";
            double temp = 360 * (Convert.ToDouble(PercentRamUsage) / 100);
            Arc1.EndAngle = temp;

            #endregion

            #region #CPU
            int PercentCpuUsage = (int)Math.Round(float.Parse(getCurrentCpuUsage()));
            Arc2Outputlbl.Content = PercentCpuUsage.ToString() + "%";
            temp = 360 * (Convert.ToDouble(PercentCpuUsage) / 100);
            Arc2.EndAngle = temp;
            #endregion
        }

        private string getCurrentCpuUsage()
        {
            return cpuCounter.NextValue().ToString();
        }

        private string getAvailableRAM()
        {
            return ramCounter.NextValue().ToString();
        }

        private double GetRAMInformation()
        {
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
               double temp = double.Parse(result["TotalVisibleMemorySize"].ToString());

                temp = temp / 1024;

                return temp;
            }

            return 0;
        }
    }
}
