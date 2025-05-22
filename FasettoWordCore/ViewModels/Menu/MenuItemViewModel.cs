using FasettoWordCore.DataModels;

namespace FasettoWordCore.ViewModels
{
    public class MenuItemViewModel : BaseViewModel
    {
        public string Text { get; set; }
        public IconType Icon { get; set; }
        public MenuItemType Type { get; set; }
    }
}
