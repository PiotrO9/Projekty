﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Nutrition_App.Converters
{
    public class Over100PercentConverter : IMultiValueConverter
    {
        public object Convert(object[] value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((value?.Length ?? 0) != 2)
            {
                return 0;
            }

            var valueType1 = value[0]?.GetType();
            var valueType2= value[1]?.GetType();
            if(valueType1 != typeof(int) || valueType2 != typeof(int))
            {
                return 0;
            }

            int freePercents =(int)value[1];

            int number = (int)value[0];


                if (freePercents >= 0)
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

            return number;
        }

        object[] IMultiValueConverter.ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return new object[] {1,2};
        }
    }
}
