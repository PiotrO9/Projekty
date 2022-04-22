using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Game2048.Converters
{
    public class BackgroundColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Label label = (Label)parameter;

            switch (label.Text)
            {
                case "0":
                    {
                        return "#FFFFFF";
                    }
                case "2":
                    {
                        return "#342C25";
                    }
                case "4":
                    {
                        return "#372F1C";
                    }
                case "8":
                    {
                        return "#F3B27A";
                    }
                case "16":
                    {
                        return "#F69664";
                    }
                case "32":
                    {
                        return "#F77C5F";
                    }
                case "64":
                    {
                        return "#F75F3B";
                    }
                case "128":
                    {
                        return "#4B3B00";
                    }
                case "256":
                    {
                        return "#EDCC62";
                    }
                case "512":
                    {
                        return "#EDC950";
                    }
                case "1024":
                    {
                        return "#E7C258";
                    }
                case "2048":
                    {
                        return "#E8BE4E";
                    }
                default:
                    {
                        return "#E8BE4E";
                    }
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
