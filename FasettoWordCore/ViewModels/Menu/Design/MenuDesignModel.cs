using FasettoWordCore.DataModels;

namespace FasettoWordCore.ViewModels
{
    public class MenuDesignModel : MenuViewModel
    {
        public static MenuDesignModel Instance => new()
        {
            Items =
            [
                new() 
                {
                    Text = "Design time header",
                    Type = MenuItemType.Header,
                },
                new() 
                {
                    Text = "Menu Item 1",
                    Icon = IconType.File,
                },
                new() 
                {
                    Text = "Menu Item 2",
                    Icon = IconType.File,
                },
                new()
                {
                    Text = "Menu Item with long text",
                    Icon = IconType.File,
                }
            ]
        };
    }
}
