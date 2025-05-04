using FasettoWord.Model;
using FasettoWord.Pages;
using System.Diagnostics;
using System.Globalization;

namespace FasettoWord.Converters
{
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Login: return new LoginPage();
                case ApplicationPage.Register: return new RegisterPage();
                case ApplicationPage.Chat: return new ChatPage();
                default: Debugger.Break(); return null;  
            }
        }
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string pageString && Enum.TryParse(typeof(ApplicationPage), pageString, out var page))
            {
                return page;
            }
            return null;
        }
    }
}
