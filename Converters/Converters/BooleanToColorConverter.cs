using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Converters
{
    public class BooleanToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color rv = Colors.Transparent;
            if(value is bool)
            {
                rv = (bool)value ? Colors.Green : Colors.Red;
            }
            return rv;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool rv = default(bool);
            if(value is Color)
            {
                if((Color)value == Colors.Red)
                {
                    rv = false;
                }
                if ((Color)value == Colors.Green)
                {
                    rv = true;
                }
            }
            return rv;
        }
    }
}




