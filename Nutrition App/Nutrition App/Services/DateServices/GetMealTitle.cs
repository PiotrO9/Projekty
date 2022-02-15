using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrition_App.Services.DateServices
{
    public static class GetMealTitle
    {
        public static string GetMealTitleMethod(string buttonName)
        {
            string result = "";

            string[] operatios = buttonName.Split('_');

            if(operatios.Length > 2)
            {
                switch(int.Parse(operatios[1]))
                {
                    case 1:
                        {
                            return "Śniadanie";
                        }
                    case 2:
                        {
                            return "Drugie śniadanie";
                        }
                    case 3:
                        {
                            return "Lunch";
                        }
                    case 4:
                        {
                            return "Obiad";
                        }
                    case 5:
                        {
                            return "Kolacja";
                        }
                }
            }

            return result;
        }
    }
}
