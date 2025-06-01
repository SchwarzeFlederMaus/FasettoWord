using FasettoWordCore;
using FasettoWordCore.ViewModels.ViewModels;
using System.Windows;

namespace FasettoWord
{
    public class UIManager : IUIManager
    {
        public Task ShowMessageAsync(MessageBoxDialogViewModel viewModel)
        {
            var tcs = new TaskCompletionSource<bool>();

            //Run in Appplication thread
            Application.Current.Dispatcher.Invoke(() =>
            {
                try
                {
                    new DialogWindow().ShowDialog();
                }
                finally
                {
                    // Set the result of the task when the dialog is closed
                    tcs.SetResult(true);
                }
            });

            return tcs.Task;
        }
    }
}
