using FasettoWordCore.DataModels;

namespace FasettoWordCore
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
