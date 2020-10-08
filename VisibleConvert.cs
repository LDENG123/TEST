using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace WpfApp4
{
    class VisibleConvert : IValueConverter
    {
   
public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string State = (string)value;
            string str = parameter as string;
            byte[] ListBit;
            BitArray Array;
            if (State != null)
            {
                ListBit = BitConverter.GetBytes(uint.Parse(State));
                Array = new BitArray(ListBit);
                if (Array[0] && str == "1")

                { return Visibility.Visible; }
                if (Array[1] && str == "2")
                {
                    return Visibility.Visible;
                }
                if (Array[2] && str == "3")
                {
                    return Visibility.Visible;
                }
                if (Array[3] && str == "4")
                {
                    return Visibility.Visible;
                }
            }
            return Visibility.Hidden;
            }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                return value.ToString();
            }
            return null;
        }
    }
}
