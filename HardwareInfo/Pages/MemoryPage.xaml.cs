using HardwareInfo.Engines;
using HardwareInfo.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace To_do_list.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy MemoryPage.xaml
    /// </summary>
    public partial class MemoryPage : Page
    {
        private DriveInfo[] _driveinfo;

        private int _drivesAmount;

        private int _currentDrive;

        public MemoryPage()
        {
            InitializeComponent();
            _driveinfo = GetDrives.GetDrivesMethod();

            if(_driveinfo.Length == 0)
            {
                _drivesAmount = 0;
            }
            else
            {
                _drivesAmount = _driveinfo.Length;
                _currentDrive = 1;

                MainFrame.Content = new DrivePage(_driveinfo, _currentDrive);
            }
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            if(_currentDrive < _drivesAmount)
            {
                _currentDrive += 1;
                MainFrame.Content = new DrivePage(_driveinfo, _currentDrive);
            }
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            if(_currentDrive > 1)
            {
                _currentDrive -= 1;
                MainFrame.Content = new DrivePage(_driveinfo, _currentDrive);
            }
        }
    }
}
