using FasettoWord.Animations;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace FasettoWord.Pages
{
    public class BasePage : Page
    {
        #region Public Properties
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;
        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;
        public float SlideSeconds { get; set; } = 0.8f;
        #endregion
        public BasePage()
        {
            if(PageLoadAnimation != PageAnimation.None)
                Visibility = Visibility.Collapsed;

            Loaded += BasePage_Loaded;
        }

        #region Animations Load / Unload
        private async void BasePage_Loaded(object sender, RoutedEventArgs e)
        {
            await AnimateIn();
        }

        private async Task AnimateIn()
        {
            if(PageLoadAnimation == PageAnimation.None) return;

            switch (PageLoadAnimation)
            {
                case PageAnimation.SlideAndFadeInFromRight:
                    var sb = new Storyboard();
                    var slideAnimation = new ThicknessAnimation { 
                        Duration = new Duration(TimeSpan.FromSeconds(SlideSeconds)),
                        From = new Thickness(WindowWidth, 0, 0, 0),
                        To = new Thickness(0),
                        DecelerationRatio = 0.9,
                    };
                    Storyboard.SetTargetProperty(slideAnimation, new PropertyPath(MarginProperty));
                    sb.Children.Add(slideAnimation);
                    sb.Begin(this);

                    Visibility = Visibility.Visible;

                    await Task.Delay(TimeSpan.FromSeconds(SlideSeconds));
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
