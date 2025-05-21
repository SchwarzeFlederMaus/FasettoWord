using FasettoWordCore.DataModels;
using System.Globalization;
using System.Windows;

namespace FasettoWord.Converters
{
    public class AlignmentConverter : BaseValueConverter<AlignmentConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ElementHorizontalAligment) return (HorizontalAlignment)value;
            else if (value is ElementVerticalAligment) return (VerticalAlignment)value;
            else throw new ArgumentException("Wrong alignment to use");
        }
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
