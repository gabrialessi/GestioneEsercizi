using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace _08_CoffeeShop.Helper
{
    public class IdToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is int val))
            {
                return Binding.DoNothing;
            }

            if (val > 8 || val < 0)
            {
                return Binding.DoNothing;
            }

            string imgName = "/Images/coffee";
            imgName += val + ".jpg";

            BitmapImage immagine = new BitmapImage();
            immagine.BeginInit();

            immagine.UriSource = new Uri(imgName, UriKind.RelativeOrAbsolute);

            immagine.EndInit();
            return immagine;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
