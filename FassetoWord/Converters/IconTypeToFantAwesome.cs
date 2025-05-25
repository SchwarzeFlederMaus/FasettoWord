using FasettoWordCore.DataModels;
using System.Globalization;
using System.Windows;

namespace FasettoWord.Converters
{
    public class IconTypeToFantAwesome : BaseValueConverter<IconTypeToFantAwesome>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is IconType iconType
                ? iconType.ToFontAwesome() // Assuming ToFontAwesome is an extension method for IconType
                : DependencyProperty.UnsetValue; // Return UnsetValue if value is not of type IconType
        }
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
