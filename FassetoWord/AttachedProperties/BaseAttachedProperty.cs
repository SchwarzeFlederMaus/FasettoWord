using System.Windows;

namespace FasettoWord.AttachedProperties
{
    /// <summary>
    /// Base class for all attached properties to replace the vanilla WPF attached property
    /// </summary>
    /// <typeparam name="Parent">The parent class to be the attached property</typeparam>
    /// <typeparam name="Property">The type of this attached property</typeparam>
    public abstract class BaseAttachedProperty<Parent, Property>
        where Parent : BaseAttachedProperty<Parent, Property>, new()
    {
        #region Events
        /// <summary>
        /// The event that is raised when the attached property changes
        /// </summary>
        public event Action<DependencyObject, DependencyPropertyChangedEventArgs> ValueChanged;
        #endregion

        #region Instance
        /// <summary>
        /// Singleton instance of this class
        /// </summary>
        public static Parent Instance { get; } = new();
        #endregion

        #region Attached Property Definition
        /// <summary>
        /// The attached property for this class
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.RegisterAttached(
                "Value",
                typeof(Property),
                typeof(BaseAttachedProperty<Parent, Property>),
                new PropertyMetadata(
                    default(Property),
                    new PropertyChangedCallback(OnValuePropertyChanged)));

        /// <summary>
        /// The callback event whet the <see cref="ValueProperty"/> changes"/>
        /// </summary>
        /// <param name="d">The UI element that hd it's property changed</param>
        /// <param name="e">The argumentsfor the event</param>
        /// <exception cref="NotImplementedException"></exception>
        private static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Instance.OnValueChanged(d, e);
            Instance.ValueChanged?.Invoke(d, e);
        }
        /// <summary>
        /// Gets the attached property
        /// </summary>
        /// <param name="d">The element to get the property from</param>
        /// <returns></returns>
        public static Property GetValue(DependencyObject d) => (Property)d.GetValue(ValueProperty);
        /// <summary>
        /// Sets the attached property
        /// </summary>
        /// <param name="d">The element to get the property from</param>
        /// <param name="value">The value to set the property to</param>
        public static void SetValue(DependencyObject d, Property value) => d.SetValue(ValueProperty, value);
        #endregion

        #region Event Methods
        public virtual void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) { }
        #endregion
    }
}
