using FasettoWordCore;
using System.Windows;
using System.Windows.Controls;

namespace FasettoWord.Controls
{
    /// <summary>
    /// Interaction logic for SideMenuControl.xaml
    /// </summary>
    public partial class SideMenuControl : UserControl
    {
        public SideMenuControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Application.LoadComponent(Application.Current.MainWindow, new System.Uri("/FasettoWord;component/Controls/SettingsControl.xaml", System.UriKind.Relative));
        }
    }
}
