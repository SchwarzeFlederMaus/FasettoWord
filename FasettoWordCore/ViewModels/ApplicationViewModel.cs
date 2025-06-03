
using FasettoWordCore.DataModels;

namespace FasettoWordCore.ViewModels
{
    public class ApplicationViewModel : BaseViewModel
    {
        //public ApplicationPage CurrentPage { get; private set; } = ApplicationPage.Login;
        //public bool IsSideMenuVisible { get; set; } = false;

        public ApplicationPage CurrentPage { get; private set; } = ApplicationPage.Chat;

        public bool IsSideMenuVisible { get; set; }

        public void GoToPage(ApplicationPage page)
        {
            CurrentPage = page;
            
            IsSideMenuVisible = page == ApplicationPage.Chat;
        }
    }
}
