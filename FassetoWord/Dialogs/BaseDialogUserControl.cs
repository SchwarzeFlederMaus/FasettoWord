using FasettoWordCore;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FasettoWord
{
    public class DialogUserControl : UserControl
    {
        private DialogWindow _dialogWindow;

        public DialogUserControl()
        {
            _dialogWindow = new DialogWindow();
            _dialogWindow.ViewModel = new DialogWindowViewModel(_dialogWindow);
        }

        public ICommand CloseCommand => new RelayCommand(_dialogWindow.Close);

        public int WindowMinimunWidth { get; set; } = 250;
        public int WindowMinimunHeight { get; set; } = 100;
        public int TitleHeight { get; set; } = 30;
        public string Title { get; set; }

        public Task ShowDialogAsync<T>(T viewModel) where T : BaseDialogViewModel
        {
            var tcs = new TaskCompletionSource<bool>();

            //Run in Appplication thread
            Application.Current.Dispatcher.Invoke(() =>
            {
                try
                {
                    _dialogWindow.ViewModel.WindowMinimunWidth = WindowMinimunWidth;
                    _dialogWindow.ViewModel.WindowMinimunHeight = WindowMinimunHeight;

                    _dialogWindow.ViewModel.TitleHeight = TitleHeight;
                    _dialogWindow.ViewModel.Title = viewModel.Title;

                    _dialogWindow.ViewModel.Content = this;

                    DataContext = viewModel;

                    _dialogWindow.ShowDialog();
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
