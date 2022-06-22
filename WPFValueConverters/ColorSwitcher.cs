using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFValueConverters
{
    public class ColorSwitcher : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string red = "C32616";
            string green = "3EC316";
            string blue = string.Format(" {0:x6}", Color.Blue.ToArgb());
            blue = blue.Remove(0, 3);
            string purple = string.Format(" {0:x6}", Color.Purple.ToArgb());
            purple = purple.Remove(0, 3);


            switch (value.ToString())
            {
                case "1":
                    return "#" + parameter + red;
                case "2":
                    return "#" + parameter + green;
                case "3":
                    return "#" + parameter + blue;
                case "4":
                    return "#" + parameter + purple;
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
