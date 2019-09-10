using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace _06_Numeri.Helper
{
    public class TextToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null)
            {
                return Binding.DoNothing;
            }
            string val = value.ToString();
            if (val.Any(c => char.IsDigit(c)))
            {
                return new SolidColorBrush(Colors.Red);
            }
            return new SolidColorBrush(Colors.MidnightBlue);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}