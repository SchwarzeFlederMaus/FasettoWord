using System.Windows;
using System.Windows.Controls;

namespace FasettoWord
{
    public class NoFrameHistory: BaseAttachedProperty<NoFrameHistory, bool>
    {
        public override void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not Frame frame) return;

            frame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
            frame.LoadCompleted += (s, e) =>
            {
                if (frame.CanGoBack)
                    frame.RemoveBackEntry();
            };
        }
    }
}
