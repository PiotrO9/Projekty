using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareInfo.Engines
{
    public static class GetDrives
    {
        public static DriveInfo[] GetDrivesMethod()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            return allDrives;
        }
    }
}
