using FasettoWordCore.Expressions;
using PropertyChanged;
using System.ComponentModel;
using System.Linq.Expressions;

namespace FasettoWordCore.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (s, e) => { };

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #region Command Helper
        /// <summary>
        /// Runs a command if the updating flag is not set.
        /// If the updating flag is true (indicating the function is already running), it will not run the command.
        /// If the updating flag is false (indicating no running function), then the action is run.
        /// Once the action is completed, the updating flag is set to false.
        /// </summary>
        /// <param name="updatingFlag">The boolean property flag defininig if the command is already running</param>
        /// <param name="func">The action to run if the command is not already running</param>
        /// <returns></returns>
        protected async Task RunCommandAsync(Expression<Func<bool>> updatingFlag, Func<Task> func)
        {
            // Check if the flag property is true (meaning the function already running)
            if (updatingFlag.GetPropertyValue())
                return;

            // Set the flag property to true (indicating the function is running)
            updatingFlag.SetPropertyValue(true);
            try
            {
                await func();
            }
            finally
            {
                // Set the flag property to false (indicating the function is no longer running)
                updatingFlag.SetPropertyValue(false);
            }

        }
        #endregion
    }
}
