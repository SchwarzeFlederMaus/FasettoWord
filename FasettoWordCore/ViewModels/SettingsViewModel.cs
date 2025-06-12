using System.Windows.Input;

namespace FasettoWordCore
{
    public class SettingsViewModel : BaseViewModel
    {
        public SettingsViewModel()
        {
            CloseCommand = new RelayCommand(Close);
        }
        public ICommand OpenCommand => new RelayCommand(() => IoC.Application.IsSettingsMenuVisible = true);
        public ICommand CloseCommand { get; set; }

        private void Close()
        {
            IoC.Application.IsSettingsMenuVisible = false;
        }
    }
}
