using System.Windows;
using System.Windows.Media.Animation;

namespace FasettoWord.Animations
{
    public static class StoryboardHelpers
    {
        public static void AddSlideFromRight(this Storyboard storyboard, double seconds, double offset, double decelerationRatio = 0.9)
        {
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(offset, 0, 0, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio,
            };

            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            storyboard.Children.Add(animation);
        }
        public static void AddFadeIn(this Storyboard storyboard, double seconds)
        {
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 0,
                To = 1,
            };          

            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));
            storyboard.Children.Add(animation);
        }

        public static void AddSlideToLeft(this Storyboard storyboard, double seconds, double offset, double decelerationRatio = 0.9)
        {
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(-offset, 0, 0, 0),
                DecelerationRatio = decelerationRatio,
            };

            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            storyboard.Children.Add(animation);
        }
        public static void AddFadeOut(this Storyboard storyboard, double seconds)
        {
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 1,
                To = 0,
            };

            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));
            storyboard.Children.Add(animation);
        }
    }
}
