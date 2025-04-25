using System.Windows;
using System.Windows.Controls;

namespace FasettoWord.AttachedProperties
{
    /// <summary>
    /// The MonitorPassword attached property for the <see cref="PasswordBox"/>
    /// </summary>
    public class MonitorPasswordProperty: BaseAttachedProperty<MonitorPasswordProperty, bool>
    {
        public override void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is PasswordBox passwordBox)
            {
                passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;
                if ((bool)e.NewValue)
                {
                    HasTextProperty.SetValue(passwordBox);
                    passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
                }
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e) => HasTextProperty.SetValue(sender as PasswordBox);
    }

    /// <summary>
    /// The HasText attached property for the <see cref="PasswordBox"/>
    /// </summary>
    public class HasTextProperty: BaseAttachedProperty<HasTextProperty, bool> 
    { 
        public static void SetValue(PasswordBox passwordBox) => SetValue(passwordBox, passwordBox.SecurePassword.Length > 0);        
    }
}
