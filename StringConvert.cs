using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace WpfApp4
{ 
    class StringConvert : IValueConverter
    {
       
      
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string atr = (string)value;
            if (value != null)
            {
                atr = atr + DateTime.Now.ToString("yyyy:M:d");
                return atr;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value != null)
            {
                return value;
            }
            return null;

        }
    }
}
