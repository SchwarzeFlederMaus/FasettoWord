using FasettoWord.Animations;
using System.Windows;

namespace FasettoWord.AttachedProperties
{
    /// <summary>
    /// A base class to run any animation method when a boolean is set to true
    /// </summary>
    /// <typeparam name="Parent"></typeparam>
    public abstract class AnimateBaseProperty<Parent> : BaseAttachedProperty<Parent, bool>
        where Parent : BaseAttachedProperty<Parent, bool>, new()
    {
        public bool FirstLoad { get; set; } = true;

        public override void OnValueUpdated(DependencyObject sender, object value)
        {
            // get the framework element
            if (sender is not FrameworkElement element) return;

            // don't fire if the value doesn't change
            if (sender.GetValue(ValueProperty) == value && !FirstLoad) return;

            if (FirstLoad)
            {
                // Create a singele self-unhookable event
                // for the elements Loaded event
                RoutedEventHandler onLoaded = null;
                onLoaded = (s, e) =>
                {
                    // remove the event handler
                    element.Loaded -= onLoaded;
                    // run the animation
                    DoAnimation(element, (bool)value);
                    // set the first load to false
                    FirstLoad = false;
                };
                // Hook into the Loaded event of the element
                element.Loaded += onLoaded;
            }
            else DoAnimation(element, (bool)value);
        }

        /// <summary>
        /// The method to run the animation
        /// </summary>
        /// <param name="element">The element</param>
        /// <param name="value">The value</param>
        protected virtual void DoAnimation(FrameworkElement element, bool value) { }
    }

    /// <summary>
    /// Animates a freamework element to slide in from the left on show
    /// and slide out to the left on hide
    /// </summary>
    public class AnimateSlideInFromLeftProperty : AnimateBaseProperty<AnimateSlideInFromLeftProperty>
    {
        protected override async void DoAnimation(FrameworkElement element, bool value)
        {
            var seconds = FirstLoad ? 0 : 0.3f;
            if (value) await element.SlideAndFadeInFromLeftAsync(seconds);
            else await element.SlideAndFadeOutToLeftAsync(seconds);

            //Infinite loop to keep the animation going
            //while (true)
            //{
            //    await Task.Delay(TimeSpan.FromSeconds(2));
            //    await element.SlideAndFadeInFromLeftAsync(1);
            //    await Task.Delay(TimeSpan.FromSeconds(2));
            //    await element.SlideAndFadeOutToLeftAsync(1);
            //}
        }
    }

    /// <summary>
    /// Animates a freamework element to slide in from the bottom on show
    /// and slide out to the left on hide
    /// </summary>
    public class AnimateSlideInFromBottomProperty : AnimateBaseProperty<AnimateSlideInFromBottomProperty>
    {
        protected override async void DoAnimation(FrameworkElement element, bool value)
        {
            var seconds = FirstLoad ? 0 : 0.3f;
            if (value) await element.SlideAndFadeInFromBottomAsync(seconds);
            else await element.SlideAndFadeOutToBottomAsync(seconds);

            //Infinite loop to keep the animation going
            //while (true)
            //{
            //    await Task.Delay(TimeSpan.FromSeconds(2));
            //    await element.SlideAndFadeInFromBottomAsync(1);
            //    await Task.Delay(TimeSpan.FromSeconds(2));
            //    await element.SlideAndFadeOutToBottomAsync(1);
            //}
        }
    }

    /// <summary>
    /// Animates a freamework element to fading in on show
    /// and fading out to hide
    /// </summary>
    public class AnimateFadeInProperty : AnimateBaseProperty<AnimateFadeInProperty>
    {
        protected override async void DoAnimation(FrameworkElement element, bool value)
        {
            var seconds = FirstLoad ? 0 : 0.3f;
            if (value) await element.FadeInAsync(seconds);
            else await element.FadeOutAsync(seconds);

            //Infinite loop to keep the animation going
            //while (true)
            //{
            //    await Task.Delay(TimeSpan.FromSeconds(2));
            //    await element.FadeInAsync(1);
            //    await Task.Delay(TimeSpan.FromSeconds(2));
            //    await element.FadeOutAsync(1);
            //}
        }
    }
}
