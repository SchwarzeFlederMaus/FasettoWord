using System.Windows;
using FasettoWord.ViewModel;

namespace FasettoWord;

/// <summary>
/// Interaction logic for DialogWindow.xaml
/// </summary>
public partial class DialogWindow : Window
{
    private DialogWindowViewModel _viewModel;
    public DialogWindowViewModel ViewModel
    {
        get => _viewModel;
        set
        {
            _viewModel = value;
            DataContext = _viewModel;
        }
    }

    public DialogWindow()
    {
        InitializeComponent();
    }
}