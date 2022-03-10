using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Nutrition_App.Converters
{
    public class Over100PercentConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var lbl = parameter as Label;
            string lblText = lbl.Text;
            int freePercents = 0;
            if(!String.IsNullOrEmpty(lblText))
            {
                freePercents = int.Parse(lblText);
            }

            if(value is int number)
            {
                if(freePercents >= 0)
                {
                    if (number > freePercents)
                    {
                        return freePercents;
                    }
                }

                if (number > 100)
                {
                    return 100;
                }
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int number)
            {
                if (number > 100)
                {
                    return 100;
                }
            }

            return value;
        }
    }
}
