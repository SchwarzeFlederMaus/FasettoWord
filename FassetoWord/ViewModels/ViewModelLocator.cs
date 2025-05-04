using FasettoWordCore;
using FasettoWordCore.ViewModels;

namespace FasettoWord
{
    public class ViewModelLocator
    {
        public static ViewModelLocator Instance { get; } = new();
        public static ApplicationViewModel ApplicationViewModel => IoC.Get<ApplicationViewModel>();
    }
}
