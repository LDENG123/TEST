using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace WpfApp4
{
    class IMultiValueConverterClass : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values != null)
            { return values[0].ToString()+ values[1].ToString(); }
            else
                return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            string[] str = null;
            if (value != null)
            { return str= value.ToString().Split( ' '); }
            else
                return null;
        }
    }
}
