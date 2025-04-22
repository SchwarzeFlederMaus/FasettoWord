using System.Windows.Input;

namespace FasettoWord.ViewModel
{
    class RelayParameterizedCommand : ICommand
    {
        private Action<object> _execute;
        public RelayParameterizedCommand(Action<object> execute)
        {
            _execute = execute;
        }
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
