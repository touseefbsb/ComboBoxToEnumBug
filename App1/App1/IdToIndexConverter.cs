using System;
using Windows.UI.Xaml.Data;

namespace App1
{
    public class IdToIndexConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language) => System.Convert.ToInt32(value) - 1;

        //not needed for one way data binding
        public object ConvertBack(object value, Type targetType, object parameter, string language) => ((int)value) + 1;
    }
}
