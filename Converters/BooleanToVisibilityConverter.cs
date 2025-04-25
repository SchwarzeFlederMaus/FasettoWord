using System.Globalization;
using System.Windows;

namespace FasettoWord.Converters
{
    public class BooleanToVisibilityConverter : BaseValueConverter<BooleanToVisibilityConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isInverted = bool.TryParse(parameter?.ToString(), out var inverted) && inverted;
            return (bool)value == isInverted ? Visibility.Hidden : Visibility.Visible;
        }
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
