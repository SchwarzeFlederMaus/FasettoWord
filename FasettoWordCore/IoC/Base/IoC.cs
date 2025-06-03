using Ninject;

namespace FasettoWordCore
{
    public static class IoC
    {
        public static IKernel Kernel { get; private set; } = new StandardKernel();
        /// <summary>
        /// Shortcut to get acces the <see cref="IUIManager"/>.
        /// </summary>
        public static IUIManager UI => Kernel.Get<IUIManager>();

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
