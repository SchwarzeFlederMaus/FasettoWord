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
        // Initialize the IoC container
        IoC.Setup();

        // Show the main window
        Current.MainWindow = new MainWindow();
        Current.MainWindow.Show();
    }
}

