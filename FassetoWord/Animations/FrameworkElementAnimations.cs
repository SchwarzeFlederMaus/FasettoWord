﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace FasettoWord.Animations
{
    public static class FrameworkElementAnimations
    {   
        #region Slide Left
        public static async Task SlideAndFadeInFromLeftAsync(this FrameworkElement element, double seconds = 0.3f, double offset = double.NaN)
        {
            var sb = new Storyboard();
            if (double.IsNaN(offset))
                offset = element.ActualWidth;
            sb.AddSlideFromLeft(seconds, offset);
            sb.AddFadeIn(seconds);
            sb.Begin(element);
            element.Visibility = Visibility.Visible;
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }
        public static async Task SlideAndFadeOutToLeftAsync(this FrameworkElement element, double seconds = 0.3f, double offset = double.NaN)
        {
            var sb = new Storyboard();
            if (double.IsNaN(offset))
                offset = element.ActualWidth;
            sb.AddSlideToLeft(seconds, offset);
            sb.AddFadeOut(seconds);
            sb.Begin(element);
            element.Visibility = Visibility.Visible;
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }
        #endregion
        #region Slide Right
        public static async Task SlideAndFadeInFromRightAsync(this FrameworkElement element, double seconds = 0.3f, double offset = double.NaN)
        {
            var sb = new Storyboard();
            if (double.IsNaN(offset))
                offset = element.ActualWidth;
            sb.AddSlideFromRight(seconds, offset);
            sb.AddFadeIn(seconds);
            sb.Begin(element);
            element.Visibility = Visibility.Visible;
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }
        public static async Task SlideAndFadeOutToRightAsync(this FrameworkElement element, double seconds = 0.3f, double offset = double.NaN)
        {
            var sb = new Storyboard();
            if (double.IsNaN(offset))
                offset = element.ActualWidth;
            sb.AddSlideToRight(seconds, offset);
            sb.AddFadeOut(seconds);
            sb.Begin(element);
            element.Visibility = Visibility.Visible;
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }
        #endregion
        #region Slide Bottom
        public static async Task SlideAndFadeInFromBottomAsync(this FrameworkElement element, double seconds = 0.3f, double offset = double.NaN)
        {
            var sb = new Storyboard();
            if (double.IsNaN(offset))
                offset = element.ActualHeight;
            sb.AddSlideFromBottom(seconds, offset);
            sb.AddFadeIn(seconds);
            sb.Begin(element);
            element.Visibility = Visibility.Visible;
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }
        public static async Task SlideAndFadeOutToBottomAsync(this FrameworkElement element, double seconds = 0.3f, double offset = double.NaN)
        {
            var sb = new Storyboard();
            if (double.IsNaN(offset))
                offset = element.ActualHeight;
            sb.AddSlideToBottom(seconds, offset);
            sb.AddFadeOut(seconds);
            sb.Begin(element);
            element.Visibility = Visibility.Visible;
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }
        #endregion
    }
}
