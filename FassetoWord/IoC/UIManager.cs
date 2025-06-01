using FasettoWordCore;

namespace FasettoWord
{
    public class UIManager : IUIManager
    {
        public Task ShowDialogAsync<T>(T viewModel) where T : BaseDialogViewModel
        {
            return new MessageBoxDialog().ShowDialogAsync(viewModel);
        }
    }
}
