using System;
using Windows.UI.Xaml.Data;

namespace NumberBoxTest.Converters {
    class IntToDoubleConverter : IValueConverter {

        public object Convert(object value, Type targetType, object parameter, string language) {
            return System.Convert.ToDouble(value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            return double.IsNaN((double)value)
                ? (parameter is object ? System.Convert.ToInt32(parameter) : 0)
                : System.Convert.ToInt32(value);
        }
    }
}
