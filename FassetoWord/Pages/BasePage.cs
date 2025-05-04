using FasettoWord.Animations;
using FasettoWord.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace FasettoWord.Pages
{
    public class BasePage<VM>: Page
        where VM : BaseViewModel, new()
    {
        #region Private Fields
        private VM _viewModel;
        #endregion

        #region Public Properties
        public VM ViewModel 
        { 
            get => _viewModel;
            set
            {
                if (_viewModel == value) return;
                _viewModel = value;
                DataContext = _viewModel;
            }
        }
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;
        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;
        public float SlideSeconds { get; set; } = 0.8f;
        #endregion

        public BasePage()
        {
            if(PageLoadAnimation != PageAnimation.None)
                Visibility = Visibility.Collapsed;

            Loaded += BasePage_Loaded;

            ViewModel = new VM();
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
                    await this.SlideAndFadeInFromRight(SlideSeconds); break;
                default: break;
            }
        }

        public async Task AnimateOut()
        {
            if (PageUnloadAnimation == PageAnimation.None) return;

            switch (PageUnloadAnimation)
            {
                case PageAnimation.SlideAndFadeOutToLeft:
                    await this.SlideAndFadeOutToLeft(SlideSeconds); break;
                default: break;
            }
        }


        #endregion
    }
}
