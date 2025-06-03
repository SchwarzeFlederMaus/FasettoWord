using FasettoWord.ViewModel;
using System.Windows;


namespace FasettoWord;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new WindowViewModel(this);
    }

    private void Window_Activated(object sender, EventArgs e)
    {
        (DataContext as WindowViewModel).DimmableOverlayVisible = false;
    }

    private void Window_Deactivated(object sender, EventArgs e)
    {
        (DataContext as WindowViewModel).DimmableOverlayVisible = true;
    }
}