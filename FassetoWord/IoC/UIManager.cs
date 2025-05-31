using FasettoWordCore;
using FasettoWordCore.ViewModels.ViewModels;
using System.Windows;

namespace FasettoWord
{
    public class UIManager : IUIManager
    {
        public Task ShowMessageAsync(MessageBoxDialogViewModel viewModel)
        {
            return Task.Run(() => 
                MessageBox.Show(viewModel.Message, viewModel.Title, MessageBoxButton.OK)
            );
        }
    }
}
