﻿namespace FasettoWordCore
{
    public class ApplicationViewModel : BaseViewModel
    {

        //TODO: Need to change this to a login page 
        public ApplicationPage CurrentPage { get; private set; } = ApplicationPage.Chat;
        //TODO: Need to delete default value
        public bool IsSideMenuVisible { get; set; } = true;
        public bool IsSettingsMenuVisible { get; set; }

        public void GoToPage(ApplicationPage page)
        {
            CurrentPage = page;
            
            IsSideMenuVisible = page == ApplicationPage.Chat;
        }
    }
}
