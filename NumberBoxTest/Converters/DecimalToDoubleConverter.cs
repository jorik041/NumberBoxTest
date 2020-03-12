using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace NumberBoxTest.Converters {
    class DecimalToDoubleConverter : IValueConverter {

        public object Convert(object value, Type targetType, object parameter, string language) {
            return System.Convert.ToDouble(value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            return double.IsNaN((double)value) ? 0M : (object)System.Convert.ToDecimal(value);
        }
    }
}
