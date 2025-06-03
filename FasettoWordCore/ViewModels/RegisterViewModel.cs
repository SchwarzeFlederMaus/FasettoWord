using FasettoWordCore.DataModels;
using System.Security;
using System.Windows.Input;

namespace FasettoWordCore
{
    public class RegisterViewModel : BaseViewModel
    {
        #region Public Properties
        public string Email { get; set; }
        public SecureString Password { get; set; }
        public bool IsRegisterRunning { get; set; }
        #endregion

        #region Commands
        public ICommand RegisterCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        #endregion

        public RegisterViewModel()
        {
            RegisterCommand = new RelayParameterizedCommand(async (parameter) => await RegisterAsync(parameter));
            LoginCommand = new RelayCommand(async () => await LoginAsync());
        }

        private async Task RegisterAsync(object parameter)
        {
            await RunCommandAsync(() => IsRegisterRunning, async () =>
            {
                //TODO: Delete delay
                await Task.Delay(2000);
            });
        }
        private async Task LoginAsync()
        {
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Login);
            await Task.Delay(1);
        }
    }
}
