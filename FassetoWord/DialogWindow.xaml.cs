using System.Windows;


namespace FasettoWord;

/// <summary>
/// Interaction logic for DialogWindow.xaml
/// </summary>
public partial class DialogWindow : Window
{
    public DialogWindow()
    {
        InitializeComponent();
        DataContext = new ViewModel.DialogWindowViewModel(this);
    }
}