using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_BMI_app.Converters
{
    public class FloatToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string ReceivedValue = value.ToString();

            if (string.IsNullOrWhiteSpace(ReceivedValue))
            {
                return "80";
            }

            float ConvertToTempFloat = float.Parse(ReceivedValue);
            int RoundedToIntType = (int)ConvertToTempFloat;

            return RoundedToIntType.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string ReceivedValue = value.ToString();

            if (string.IsNullOrWhiteSpace(ReceivedValue))
            {
                return "80";
            }

            float ConvertToTempFloat = float.Parse(ReceivedValue);
            int RoundedToIntType = (int)ConvertToTempFloat;

            return RoundedToIntType.ToString();
        }
    }
}
