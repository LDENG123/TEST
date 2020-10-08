using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApp4
{
    class ColorConverter : IValueConverter
    {

        public enum Lights
            {
               GREEN,
                YELLOW,
              RED
           }
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string State = (string)value;
            string str = parameter as string;
            byte[] ListBit;
            BitArray Array;
            if (State!=null)
            {
           ListBit = BitConverter.GetBytes(uint.Parse( State));
            Array = new BitArray(ListBit);

                if (Array[0] && str == "RDY")

                { return new SolidColorBrush(Colors.Red); }
                if (Array[1] && str == "ALM")
            {
                return new SolidColorBrush(Colors.Red);
            }
            if (Array[2] && str == "LMT11+")
            {
                return new SolidColorBrush(Colors.Red);
            }
            if (Array[3] && str == "LMT-")
            {
                return new SolidColorBrush(Colors.Red);
            }
            if (Array[4] && str == "ORG")
            {
                return new SolidColorBrush(Colors.Red);
            }
            if (Array[5] && str == "DIR")
            {
                return new SolidColorBrush(Colors.Red);  
            }
            if (Array[6] && str == "EMG")
            {
                return new SolidColorBrush(Colors.Red);
            }
            if (Array[7] && str == "PCS")
            {
                return new SolidColorBrush(Colors.Red);
            }
            if (Array[8] && str == "INP")
            {
                return new SolidColorBrush(Colors.Red);
            }
            if (Array[9] && str == "SVON")
            {
                return new SolidColorBrush(Colors.Red);
            }
            if (Array[10] && str == "SVON1")
            {
                return new SolidColorBrush(Colors.Red);
            }
            if (Array[11] && str == "CLR")
            {
                return new SolidColorBrush(Colors.Red);
            } }
        
            return Colors.Gray;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
