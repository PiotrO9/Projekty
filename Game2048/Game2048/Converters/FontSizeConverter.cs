using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Game2048.Converters
{
    public class FontSizeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Label label = (Label)parameter;

            switch (label.Text.Length)
            {
                case 1:
                    {
                        return 20;
                    }
                case 2:
                    {
                        return 18;
                    }
                case 3:
                    {
                        return 14;
                    }
                case 4:
                    {
                        return 12;
                    }
                default:
                    {
                        return 20;
                    }
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
