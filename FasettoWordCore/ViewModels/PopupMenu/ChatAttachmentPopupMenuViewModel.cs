using FasettoWordCore.DataModels;

namespace FasettoWordCore.ViewModels
{
    public class ChatAttachmentPopupMenuViewModel : BasePopupViewModel
    {
        public ChatAttachmentPopupMenuViewModel()
        {
            Content = new MenuViewModel()
            {
                Items =
                [
                    new() { Text = "Attach a file...", Type = MenuItemType.Header, },
                    new() { Text = "From Computer", Icon = IconType.File, },
                    new() { Text = "From Pictures", Icon = IconType.Picture, },
                ]
            };
        }
    }
}
