using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareInfo.Engines
{
    public static class CutLastTwoChar
    {
        public static string Method(string text)
        {
            if (text.Length > 2)
            {
                string temp = text.Remove(text.Length - 2,2);
                temp += "GB";
                return temp;
            }
            else return text;
        }
    }
}
