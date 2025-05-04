using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace FasettoWord.Converters
{
    public class StringRGBToBrushConverter : BaseValueConverter<StringRGBToBrushConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new BrushConverter().ConvertFrom($"#{value}");
        }
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
