using System.Windows;

namespace FasettoWord.ViewModel
{
    class WindowViewModel : BaseViewModel
    {
        private Window _window;
        private int _outerMarginSize = 10;
        private int _windwoRadius = 10;

        public WindowViewModel(Window window)
        {
            _window = window;
        }

        public int ResizeBorder { get; set; } = 6;
        public Thickness ResizeBorderThickness => new(ResizeBorder);
        public int OuterMarginSize
        {
            get => _window.WindowState == WindowState.Maximized ? 0 : _outerMarginSize;
            set => _outerMarginSize = value;

        }
        public int WindowRadius
        {
            get => _window.WindowState == WindowState.Maximized ? 0 : _windwoRadius;
            set => _windwoRadius = value;
        }
    }
}
