using FasettoWordCore;
using System.Globalization;
using System.Windows;

namespace FasettoWord.Converters
{
    public class MenuItemTypeVisibilityConverter : BaseValueConverter<MenuItemTypeVisibilityConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter is null) 
                return Visibility.Collapsed;

            if(!Enum.TryParse(parameter.ToString(), out MenuItemType menuItemType)) 
                return Visibility.Collapsed;

            return value is MenuItemType itemType && itemType == menuItemType
                ? Visibility.Visible
                : Visibility.Collapsed;
        }
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
