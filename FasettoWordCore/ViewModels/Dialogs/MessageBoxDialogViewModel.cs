namespace FasettoWordCore.ViewModels.ViewModels
{
    public class MessageBoxDialogViewModel : BaseViewModel
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string OkButtonText { get; set; } = "OK";
    }
}
