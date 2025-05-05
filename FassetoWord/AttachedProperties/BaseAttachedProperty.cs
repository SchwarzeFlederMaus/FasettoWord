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
        public event Action<DependencyObject, object> ValueUpdated;
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
                    new PropertyChangedCallback(OnValuePropertyChanged),
                    new CoerceValueCallback(OnValuePropertyUpdated)));


        /// <summary>
        /// The callback event when the <see cref="ValueProperty"/> changes"/>
        /// </summary>
        /// <param name="d">The UI element that hd it's property changed</param>
        /// <param name="e">The arguments for the event</param>
        /// <exception cref="NotImplementedException"></exception>
        private static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Instance.OnValueChanged(d, e);
            Instance.ValueChanged?.Invoke(d, e);
        }
        /// <summary>
        /// The callback event when the <see cref="ValueProperty"/> is changed, even if it's the same value"/>
        /// </summary>
        /// <param name="d">The UI element that hd it's property changed</param>
        /// <param name="value">value</param>
        /// <exception cref="NotImplementedException"></exception>
        private static object OnValuePropertyUpdated(DependencyObject d, object value)
        {
            Instance.OnValueUpdated(d, value);
            Instance.ValueUpdated?.Invoke(d, value);
            return value;
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
        public virtual void OnValueUpdated(DependencyObject d, object value) { }
        #endregion
    }
}
