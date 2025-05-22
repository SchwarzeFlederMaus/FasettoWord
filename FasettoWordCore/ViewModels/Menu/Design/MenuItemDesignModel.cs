using FasettoWordCore.DataModels;

namespace FasettoWordCore.ViewModels
{
    public class MenuItemDesignModel : MenuItemViewModel
    {
        public static MenuItemDesignModel Instance => new()
        {            
            Text = "Hello",
            Icon = IconType.File,
        };
    }
}
