using FasettoWordCore;
using System.Windows.Controls;

namespace FasettoWord.Controls
{
    /// <summary>
    /// Interaction logic for SettingsControl.xaml
    /// </summary>
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();

            // Set the DataContext to the SettingsViewModel from IoC
            // TODO: This should be done in the ViewModelLocator or similar, not directly in the view
            DataContext = IoC.Settings;
        }
    }
}
