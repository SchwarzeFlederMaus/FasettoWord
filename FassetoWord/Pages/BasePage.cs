using FasettoWord.Animations;
using FasettoWordCore.ViewModels;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace FasettoWord.Pages
{
    public class BasePage : UserControl
    {
        public BasePage()
        {
            if (DesignerProperties.GetIsInDesignMode(this)) return;

            Loaded += BasePage_Loaded;
        }

        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;
        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;
        public float SlideSeconds { get; set; } = 0.4f;
        public bool IsAnimatingOut { get; set; }

        private async void BasePage_Loaded(object sender, RoutedEventArgs e)
        {
            if (IsAnimatingOut) 
                await AnimateOutAsync();
            else 
                await AnimateInAsync();
        }
        private async Task AnimateInAsync()
        {
            if (PageLoadAnimation == PageAnimation.None) return;

            switch (PageLoadAnimation)
            {
                case PageAnimation.SlideAndFadeInFromRight:
                    await this.SlideAndFadeInFromRightAsync(SlideSeconds, Width); break;
                default: break;
            }
        }
        private async Task AnimateOutAsync()
        {
            if (PageUnloadAnimation == PageAnimation.None) return;

            switch (PageUnloadAnimation)
            {
                case PageAnimation.SlideAndFadeOutToLeft:
                    await this.SlideAndFadeOutToLeftAsync(SlideSeconds, Width); break;
                default: break;
            }
        }
    }
    public class BasePage<VM>: BasePage
        where VM : BaseViewModel, new()
    {
        private VM _viewModel;
       
        public BasePage() : base() 
        {
            ViewModel = new VM();
        }

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
    }
}
