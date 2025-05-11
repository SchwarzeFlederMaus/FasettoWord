using System.Globalization;
using System.Windows;

namespace FasettoWord.Converters
{
    public class DateTimeOffsetToReadTimeConventer : BaseValueConverter<DateTimeOffsetToReadTimeConventer>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var time = (DateTimeOffset)value;

            if (time == DateTimeOffset.MinValue)
                return DependencyProperty.UnsetValue;

            string result;
            if (time.Date == DateTimeOffset.UtcNow.Date)
                result = time.ToLocalTime().ToString("t");
            else if (time.Date == DateTimeOffset.UtcNow.AddDays(-7).Date)
                result = time.ToLocalTime().ToString("ddd t");
            else if (time.Date.Year == DateTimeOffset.UtcNow.Year)
                result = time.ToLocalTime().ToString("MMM d t");
            else
                result = time.ToLocalTime().ToString("MMM d, yyyy t");

            return $"Read at {result}";
        }
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
