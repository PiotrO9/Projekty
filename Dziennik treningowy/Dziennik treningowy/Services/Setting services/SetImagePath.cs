using System;
using System.Collections.Generic;
using System.Text;

namespace Dziennik_treningowy.Services.Setting_services
{
    public static class SetImagePath
    {
        public static string Method(string pickedExercise)
        {
            string result = "";

            switch(pickedExercise)
            {
                case "OHP":
                    {
                        result += "OHP.jpg";
                        break;
                    }
                case "Wyciskanie sztangi na ławce płaskiej":
                    {
                        result += "Barell_benchpress.jpg";
                        break;
                    }
                default:
                    {
                        result = "";
                        break;
                    }
            }


            return result;
        }
    }
}
