using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace FasettoWord.Animations
{
    public static class FrameworkElementAnimations
    {
        public static async Task SlideAndFadeInFromRightAsync(this FrameworkElement element, double seconds = 0.3f)
        {
            var sb = new Storyboard();
            sb.AddSlideFromRight(seconds, element.ActualWidth);
            sb.AddFadeIn(seconds);
            sb.Begin(element);
            element.Visibility = Visibility.Visible;
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }
        public static async Task SlideAndFadeInFromLeftAsync(this FrameworkElement element, double seconds = 0.3f)
        {
            var sb = new Storyboard();
            sb.AddSlideFromLeft(seconds, element.ActualWidth);
            sb.AddFadeIn(seconds);
            sb.Begin(element);
            element.Visibility = Visibility.Visible;
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }
        public static async Task SlideAndFadeOutToLeftAsync(this FrameworkElement element, double seconds = 0.3f)
        {
            var sb = new Storyboard();
            sb.AddSlideToLeft(seconds, element.ActualWidth);
            sb.AddFadeOut(seconds);
            sb.Begin(element);
            element.Visibility = Visibility.Visible;
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }
        public static async Task SlideAndFadeOutToRightAsync(this FrameworkElement element, double seconds = 0.3f)
        {
            var sb = new Storyboard();
            sb.AddSlideToRight(seconds, element.ActualWidth);
            sb.AddFadeOut(seconds);
            sb.Begin(element);
            element.Visibility = Visibility.Visible;
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }
    }
}
