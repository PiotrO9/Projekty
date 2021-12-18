using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Nutrition_App.Services.ConvertingServices
{
    public static class GetButtonPosition
    {
        public static (int, int) GetButtonPositionMethod(Button button)
        {
            string btnName = nameof(button);
            string[] separatedDatas = btnName.Split('_');

            return (int.Parse(separatedDatas[0]), int.Parse(separatedDatas[1]));
        }

    }
}
