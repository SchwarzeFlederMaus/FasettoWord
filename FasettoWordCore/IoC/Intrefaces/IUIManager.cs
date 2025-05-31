using FasettoWordCore.ViewModels.ViewModels;

namespace FasettoWordCore
{
    public interface IUIManager
    {
        Task ShowMessageAsync(MessageBoxDialogViewModel viewModel);
    }
}
