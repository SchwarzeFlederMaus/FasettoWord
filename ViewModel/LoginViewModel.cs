using FasettoWord.Security;
using FasettoWord.ViewModel.Base;
using System.Security;
using System.Windows.Input;

namespace FasettoWord.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        #region Public Properties
        public string Email { get; set; }
        public SecureString Password { get; set; }
        #endregion

        #region Commands
        public ICommand LoginCommand { get; set; }
        #endregion

        public LoginViewModel()
        {
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await Login(parameter));
        }

        private async Task Login(object parameter)
        {
            await Task.Delay(500);

            var pass = ((IHavePassword)parameter).SecurePassword.Unsecure();
        }
    }
}
