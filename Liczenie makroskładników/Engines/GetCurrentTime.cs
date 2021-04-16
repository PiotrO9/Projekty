using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczenie_makroskładników.Engines
{
    static class GetCurrentTime
    {
        public static string GetCurrentTimeFunction()
        {
            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString();
            string day = DateTime.Now.Day.ToString();

            string hour = DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute.ToString();
            string second = DateTime.Now.Second.ToString();

            string temp = day + "-" + month + "-" + year + " " + " " + hour + "." + minute + "." + second;

            return temp;
        }

    }
}
