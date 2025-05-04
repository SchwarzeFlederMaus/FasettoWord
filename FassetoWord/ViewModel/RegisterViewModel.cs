using FasettoWord.Security;
using FasettoWord.ViewModel.Base;
using System.Security;
using System.Windows.Input;

namespace FasettoWord.ViewModel
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
        #endregion

        public RegisterViewModel()
        {
            RegisterCommand = new RelayParameterizedCommand(async (parameter) => await RegisterAsync(parameter));
        }

        private async Task RegisterAsync(object parameter)
        {
            await RunCommand(() => IsRegisterRunning, async () =>
            {
                //TODO: Delete delay
                await Task.Delay(2000);

                var email = Email;
                var pass = ((IHavePassword)parameter).SecurePassword.Unsecure();
            });

        }
    }
}
