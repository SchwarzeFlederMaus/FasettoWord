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
                    Type = MenuItemType.Header,
                    Text = "Attach a file",
                },
                new() 
                {
                    Text = "From computer",
                    Icon = IconType.File,
                },
                new() 
                {
                    Text = "From Pictures",
                    Icon = IconType.File,
                }
            ]
        };
    }
}
