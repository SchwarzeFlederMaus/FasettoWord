using System.Windows.Input;

namespace FasettoWordCore.ViewModels
{
    public class ChatMessageListViewModel : BaseViewModel
    {
        public ChatMessageListViewModel()
        {
            AttachmentButtonCommand = new RelayCommand(AttachmentButton);
        }
        #region Properties
        public List<ChatMessageListItemViewModel> Items { get; set; } 
        public bool IsAttachmentButtonVisible { get; set; }
        public ChatAttachmentPopupMenuViewModel AttachmentMenu { get; set; }
        public ICommand AttachmentButtonCommand { get; set; }
        #endregion

        private void AttachmentButton()
        {
            IsAttachmentButtonVisible ^= true;
            AttachmentMenu = new ChatAttachmentPopupMenuViewModel();
        }
    }
}
