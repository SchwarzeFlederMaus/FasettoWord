using System.Diagnostics;
using System.Globalization;
using FasettoWordCore;

namespace FasettoWord.Converters
{
    public class IoCConverter : BaseValueConverter<IoCConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((string)parameter)
            {
                case nameof(ApplicationViewModel): return IoC.Get<ApplicationViewModel>();
                default: Debugger.Break(); return null;  
            }
        }
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
