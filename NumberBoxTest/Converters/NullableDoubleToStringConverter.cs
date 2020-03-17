using System;
using System.Globalization;
using Windows.UI.Xaml.Data;

namespace NumberBoxTest.Converters {
    class NullableDoubleToStringConverter : IValueConverter {

        public object Convert(object value, Type targetType, object parameter, string language) {
            return value is object ? value.ToString() : string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            var ci = CultureInfo.GetCultureInfo(language);
            return string.IsNullOrWhiteSpace((string)value) ? (double?)null : double.Parse((string)value, ci);
        }
    }
}
