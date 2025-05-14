using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FasettoWord.AttachedProperties
{
    public class IsFocusedProperty: BaseAttachedProperty<IsFocusedProperty, bool>
    {
        public override void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Control control)
            {
                if ((bool)e.NewValue) control.Focus();
                else Keyboard.ClearFocus();
            }
        }
    }
}
