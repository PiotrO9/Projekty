﻿using HardwareInfo.Engines;
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
    /// Logika interakcji dla klasy RAMPage.xaml
    /// </summary>
    public partial class RAMPage : Page
    {
        public RAMPage()
        {
            InitializeComponent();
            GetRAMInformation();
        }

        private void GetRAMInformation()
        {
            ObjectQuery objectQuery = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(objectQuery);
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();

            foreach (ManagementObject managementObject in managementObjectCollection)
            {
                SizeSuffixTransform sizeSuffixTransform = new SizeSuffixTransform();

                TotalVisibleMemoryLabelOutput.Content = CutLastTwoChar.Method(sizeSuffixTransform.SizeSuffixMethod(int.Parse(managementObject["TotalVisibleMemorySize"].ToString())));
                FreePhysicalMemoryLabelOutput.Content = CutLastTwoChar.Method(sizeSuffixTransform.SizeSuffixMethod(int.Parse(managementObject["FreePhysicalMemory"].ToString())));
            }
        }
    }
}
