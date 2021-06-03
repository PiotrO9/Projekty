using System;
using System.Collections.Generic;
using System.Text;

namespace To_do_list.Engines
{
     static class CreateFileName
    {
        public static string Method()
        {
            string result = "";

            int DateTimeYear = DateTime.Now.Year;
            int DateTimeMonth = DateTime.Now.Month;
            int DateTimeDay = DateTime.Now.Day;

            Random rnd = new Random();
            int id = rnd.Next(1, 5000);

            result += DateTimeDay + "_" + DateTimeMonth + "_" + DateTimeYear + "_" + id;

            return result;
        }    
    }
}
