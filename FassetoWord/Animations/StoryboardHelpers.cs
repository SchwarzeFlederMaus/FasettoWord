using System.Windows;
using System.Windows.Media.Animation;

namespace FasettoWord
{
    public static class StoryboardHelpers
    {
       
        #region Slide Left
        public static void AddSlideFromLeft(this Storyboard storyboard, double seconds, double offset, double decelerationRatio = 0.9)
        {
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(-offset, 0, 0, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio,
            };

            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
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
        #endregion
        #region Slide Right
        public static void AddSlideFromRight(this Storyboard storyboard, double seconds, double offset, double decelerationRatio = 0.9)
        {
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0, 0, -offset, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio,
            };

            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            storyboard.Children.Add(animation);
        }
        public static void AddSlideToRight(this Storyboard storyboard, double seconds, double offset, double decelerationRatio = 0.9)
        {
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(0, 0, -offset, 0),
                DecelerationRatio = decelerationRatio,
            };

            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            storyboard.Children.Add(animation);
        }
        #endregion
        #region Slide Bottom
        public static void AddSlideFromBottom(this Storyboard storyboard, double seconds, double offset, double decelerationRatio = 0.9)
        {
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0, offset, 0, -offset),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio,
            };

            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            storyboard.Children.Add(animation);
        }
        public static void AddSlideToBottom(this Storyboard storyboard, double seconds, double offset, double decelerationRatio = 0.9)
        {
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(0, offset, 0, -offset),
                DecelerationRatio = decelerationRatio,
            };

            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            storyboard.Children.Add(animation);
        }
        #endregion
        #region Slide
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
        #endregion
    }
}
