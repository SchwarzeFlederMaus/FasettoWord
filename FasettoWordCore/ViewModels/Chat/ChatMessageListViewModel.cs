using System.Windows.Input;

namespace FasettoWordCore.ViewModels
{
    public class ChatMessageListViewModel : BaseViewModel
    {
        public ChatMessageListViewModel()
        {
            AttachmentButtonCommand = new RelayCommand(AttachmentButton);
            PopupClickawayCommand = new RelayCommand(PopupClickaway);
            SendCommand = new RelayCommand(Send);
        }

        #region Properties
        public List<ChatMessageListItemViewModel> Items { get; set; }
        public bool IsAttachmentPopupVisible { get; set; }
        public bool IsAnyPopupVisible => IsAttachmentPopupVisible;
        public ChatAttachmentPopupMenuViewModel AttachmentMenu => new();
        public ICommand AttachmentButtonCommand { get; set; }
        public ICommand PopupClickawayCommand { get; set; }
        public ICommand SendCommand { get; set; }
        #endregion

        private void AttachmentButton() => IsAttachmentPopupVisible ^= true;
        private void PopupClickaway() => IsAttachmentPopupVisible = false;
        private void Send()
        {
            IoC.UI.ShowDialogAsync<MessageBoxDialogViewModel>(new()
            {
                Title = "Send Message",
                Message = "This is a test message",
                OkButtonText = "OK"
            });
        }
    }
}
