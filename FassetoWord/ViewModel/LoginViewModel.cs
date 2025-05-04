using FasettoWord.Security;
using FasettoWord.ViewModel.Base;
using System.Security;
using System.Windows.Input;
using System.Windows;

namespace FasettoWord.ViewModel
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
            await RunCommand(() => IsLoginRunning, async () =>
            {
                //TODO: Delete delay
                await Task.Delay(2000);

                var email = Email;
                var pass = ((IHavePassword)parameter).SecurePassword.Unsecure();
            });

        }
        private async Task RegisterAsync()
        {
            //TODO: Need to move to register page
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = Model.ApplicationPage.Register;
            await Task.Delay(1);
        }
    }
}
