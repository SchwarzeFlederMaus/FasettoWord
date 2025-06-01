
namespace FasettoWordCore
{
    public interface IUIManager
    {
        Task ShowDialogAsync<T>(T viewModel) where T : BaseDialogViewModel;
    }
}
