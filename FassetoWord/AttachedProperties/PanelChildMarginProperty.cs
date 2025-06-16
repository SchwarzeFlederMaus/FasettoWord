using System.Windows;
using System.Windows.Controls;

namespace FasettoWord
{
    public class PanelChildMarginProperty: BaseAttachedProperty<PanelChildMarginProperty, string>
    {
        public override void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not Panel panel) return;
            
            panel.Loaded += (s, a) =>
            {
                foreach (var child in panel.Children)
                {
                    if (child is FrameworkElement element && e.NewValue is string str)
                    {
                        element.Margin = (Thickness)new ThicknessConverter().ConvertFromString(str);
                    }
                }
            };
            
        }
    }
}
