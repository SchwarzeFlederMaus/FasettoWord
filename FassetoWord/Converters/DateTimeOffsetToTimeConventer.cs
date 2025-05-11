using System.Globalization;
using System.Windows;

namespace FasettoWord.Converters
{
    public class DateTimeOffsetToTimeConventer : BaseValueConverter<DateTimeOffsetToTimeConventer>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var time = (DateTimeOffset)value;

            if (time.Date == DateTimeOffset.UtcNow.Date)
                return time.ToLocalTime().ToString("t");
            else if (time.Date == DateTimeOffset.UtcNow.AddDays(-7).Date)
                return time.ToLocalTime().ToString("ddd t");
            else if (time.Date.Year == DateTimeOffset.UtcNow.Year)
                return time.ToLocalTime().ToString("MMM d t");
            else
                return time.ToLocalTime().ToString("MMM d, yyyy t");
        }
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
