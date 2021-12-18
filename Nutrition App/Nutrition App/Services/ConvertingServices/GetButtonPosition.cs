using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Nutrition_App.Services.ConvertingServices
{
    public static class GetButtonPosition
    {
        public static (int, int) GetButtonPositionMethod(string ButtonName)
        {
            string[] separatedDatas = ButtonName.Split('_');

            return (int.Parse(separatedDatas[1]), int.Parse(separatedDatas[2]));
        }

    }
}
