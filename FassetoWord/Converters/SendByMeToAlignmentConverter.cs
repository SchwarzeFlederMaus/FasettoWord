using System.Globalization;
using System.Windows;

namespace FasettoWord.Converters
{
    public class SendByMeToAlignmentConverter : BaseValueConverter<SendByMeToAlignmentConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isByMe = (bool)value;
            bool invert = parameter != null;
            return (isByMe ^ invert) ? HorizontalAlignment.Right : HorizontalAlignment.Left;
        }
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
