using FasettoWord.Pages;
using System.Windows;
using System.Windows.Controls;

namespace FasettoWord.Controls
{
    /// <summary>
    /// Interaction logic for PageHost.xaml
    /// </summary>
    public partial class PageHost : UserControl
    {
        public BasePage CurrentPage
        {
            get => (BasePage)GetValue(CurrentPageProperty); 
            set => SetValue(CurrentPageProperty, value); 
        }

        public static readonly DependencyProperty CurrentPageProperty =
            DependencyProperty.Register(nameof(CurrentPage), typeof(BasePage), typeof(PageHost), new UIPropertyMetadata(CurrentPagePropertyChange));

        public PageHost()
        {
            InitializeComponent();
        }

        private static void CurrentPagePropertyChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not PageHost pageHost) return;

            var newPageFrame = pageHost.NewFrame;
            var oldPageFrame = pageHost.OldFrame;

            var oldFrameContent = newPageFrame.Content;
            newPageFrame.Content = null;
            oldPageFrame.Content = oldFrameContent;

            if (oldFrameContent is BasePage oldPage)
            {
                oldPage.IsAnimatingOut = true;

                Task.Delay((int)(oldPage.SlideSeconds * 1000)).ContinueWith(t =>
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        oldPageFrame.Content = null;
                    });
                });
            }

            newPageFrame.Content = e.NewValue;
        }
    }
}
