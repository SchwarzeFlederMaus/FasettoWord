using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace FasettoWord.Converters
{
    public class SendByMeToBackgroundConverter : BaseValueConverter<SendByMeToBackgroundConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var resourceKey = (bool)value ? "WordVeryLightBlueBrush" : "ForegroundLightBrush";
            return Application.Current.FindResource(resourceKey);
        }
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
