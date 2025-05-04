using FasettoWordCore.ViewModels;
using Ninject;

namespace FasettoWordCore
{
    public static class IoC
    {
        public static IKernel Kernel { get; private set; } = new StandardKernel();

        public static T Get<T>() => Kernel.Get<T>();

        public static void Setup()
        {
            BindViewModels();
        }
        private static void BindViewModels()
        {
            // Bind all the services and view models here
            Kernel.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel());
        }
    }
}
