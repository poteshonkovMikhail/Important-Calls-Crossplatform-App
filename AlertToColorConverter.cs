using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace Important_Calls
{
    public class AlertToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isAlert && isAlert)
            {
                return Colors.Cyan; // Цвет для контактов с Alert=true
            }
            return Colors.Transparent; // Цвет для остальных
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}