using System.Windows;
using System.Windows.Controls;

namespace FasettoWord.ViewModel
{
    class DialogWindowViewModel : WindowViewModel
    {
        public DialogWindowViewModel(Window window) : base(window) 
        {
            WindowMinimunWidth = 250;
            WindowMinimunHeight = 100;

            TitleHeight = 30;
        }

        #region Properties
        public string Title { get; set; } = "Dialog Window";
        public Control Content { get; set; }
        #endregion
    }
}
