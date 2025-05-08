using FasettoWordCore.DataModels;
using FasettoWordCore.Security;
using System.Security;
using System.Windows.Input;

namespace FasettoWordCore.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Public Properties
        public string Email { get; set; }
        public SecureString Password { get; set; }
        public bool IsLoginRunning { get; set; }
        #endregion

        #region Commands
        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }
        #endregion

        public LoginViewModel()
        {
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await LoginAsync(parameter));
            RegisterCommand = new RelayCommand(async () => await RegisterAsync());
        }

        private async Task LoginAsync(object parameter)
        {
            await RunCommandAsync(() => IsLoginRunning, async () =>
            {
                //TODO: Delete delay
                await Task.Delay(1000);

                //var email = Email;
                //var pass = ((IHavePassword)parameter).SecurePassword.Unsecure();

                //Go to the chat page
                IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Chat);
            });

        }
        private async Task RegisterAsync()
        {
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Register);
            await Task.Delay(1);
        }
    }
}
