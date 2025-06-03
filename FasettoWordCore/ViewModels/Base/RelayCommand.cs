using System.Windows.Input;

namespace FasettoWordCore
{
    public class RelayCommand : ICommand
    {
        private Action _execute;
        public RelayCommand(Action execute)
        {
            _execute = execute;
        }
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter)
        {
            _execute();
        }
    }
}
