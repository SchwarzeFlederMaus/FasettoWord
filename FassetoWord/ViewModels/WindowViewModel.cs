using FasettoWordCore.DataModels;
using FasettoWordCore.ViewModels;
using System.Windows;
using System.Windows.Input;

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

            _window.StateChanged += (s, e) =>
            {
                OnPropertyChanged(nameof(ResizeBorder));
                OnPropertyChanged(nameof(ResizeBorderThickness));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(OuterMarginSizeThickness));
                OnPropertyChanged(nameof(WindowRadius));
                OnPropertyChanged(nameof(WindowCornerRadius));
            };

            MinimizeCommand = new RelayCommand(() => _window.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => _window.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => _window.Close());
            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(_window, _window.PointToScreen(Mouse.GetPosition(_window))));

            var resizer = new WindowResizer(_window);
        }

        #region Commands
        public ICommand MinimizeCommand { get; set; }
        public ICommand MaximizeCommand { get; set; }
        public ICommand CloseCommand { get; set; }
        public ICommand MenuCommand { get; set; }
        #endregion

        #region Properties
        public double WindowMinimunWidth => 800;
        public double WindowMinimunHeight => 500;
        public bool IsBorderless => _window.WindowState == WindowState.Maximized;
        public int ResizeBorder => IsBorderless ? 0 : 6;
        public Thickness ResizeBorderThickness => new(ResizeBorder + OuterMarginSize);
        public Thickness InnerContentPaddingThickness => new(0);
        public int OuterMarginSize
        {
            get => _window.WindowState == WindowState.Maximized ? 0 : _outerMarginSize;
            set => _outerMarginSize = value;

        }
        public Thickness OuterMarginSizeThickness => new(OuterMarginSize);
        public int WindowRadius
        {
            get => _window.WindowState == WindowState.Maximized ? 0 : _windwoRadius;
            set => _windwoRadius = value;
        }
        public CornerRadius WindowCornerRadius => new(WindowRadius);
        public int TitleHeight => 42;
        public GridLength TitleHeightGridLength => new(TitleHeight + ResizeBorder);
        #endregion

        #region Private Helpers
        #endregion
    }
}
