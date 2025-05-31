using FasettoWordCore;
using System.Windows;

namespace FasettoWord;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        ApplicationSetup();

        // Show the main window
        Current.MainWindow = new MainWindow();
        Current.MainWindow.Show();
    }
    private void ApplicationSetup()
    {
        IoC.Setup();
        
        IoC.Kernel.Bind<IUIManager>().ToConstant(new UIManager());
    }
}

