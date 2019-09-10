using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace _01_Contadino.Helper
{
    class IntToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int)
            {
                int val = (int)value;
                SolidColorBrush re = val <= 35 ? val <= 20 ? new SolidColorBrush(Colors.Green) /*"green"*/ : new SolidColorBrush(Colors.Yellow) /*"yellow"*/ : new SolidColorBrush(Colors.Red) /*"red"*/;
                return re;
            }

            return new SolidColorBrush(Colors.Black);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
