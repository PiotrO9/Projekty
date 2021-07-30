using HardwareInfo.Engines;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace HardwareInfo.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy DrivePage.xaml
    /// </summary>
    public partial class DrivePage : Page
    {
        private DriveInfo[] _driveinfo;

        private int _number;

        public DrivePage(DriveInfo[] driveinfo, int number)
        {
            _driveinfo = driveinfo;
            _number = number;

            InitializeComponent();
            SetLabels();
        }

        private void SetLabels()
        {
            DriveNameLabelOutput.Content = _driveinfo[_number - 1].Name;
            DriveTypeLabelOutput.Content = _driveinfo[_number - 1].DriveFormat;
            FileSystemLabelOutput.Content = _driveinfo[_number - 1].DriveFormat;

            SizeSuffixTransform sizeSuffix = new SizeSuffixTransform();

            TotalSpaceLabelOutput.Content = sizeSuffix.SizeSuffixMethod(_driveinfo[_number - 1].TotalSize);
            AvaibleSpaceLabelOutput.Content = sizeSuffix.SizeSuffixMethod(_driveinfo[_number - 1].AvailableFreeSpace);
        }
    }
}
