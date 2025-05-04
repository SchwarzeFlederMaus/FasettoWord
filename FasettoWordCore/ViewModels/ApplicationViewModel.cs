
using FasettoWordCore.DataModels;

namespace FasettoWordCore.ViewModels
{
    public class ApplicationViewModel : BaseViewModel
    {
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;
    }
}
