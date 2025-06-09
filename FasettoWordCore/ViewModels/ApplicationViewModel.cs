namespace FasettoWordCore
{
    public class ApplicationViewModel : BaseViewModel
    {
        //public ApplicationPage CurrentPage { get; private set; } = ApplicationPage.Login;
        //public bool IsSideMenuVisible { get; set; }

        public ApplicationPage CurrentPage { get; private set; } = ApplicationPage.Login;

        public bool IsSideMenuVisible { get; set; }

        public void GoToPage(ApplicationPage page)
        {
            CurrentPage = page;
            
            IsSideMenuVisible = page == ApplicationPage.Chat;
        }
    }
}
