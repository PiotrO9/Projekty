using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace HardwareInfo.Engines
{
    public class FillGpuList
    {
        private static List<ManagementObject> ListOfObjects = new List<ManagementObject>();

        public static List<ManagementObject> Method(ManagementObjectSearcher managementObjectSearcher)
        {
            foreach (ManagementObject obj in managementObjectSearcher.Get())
            {
                ListOfObjects.Add(obj);
            }

            return ListOfObjects;
        }
    }
}
