using System.Windows;
using System.Windows.Controls;

namespace FasettoWord
{
    public class DialogWindowViewModel : WindowViewModel
    {
        public DialogWindowViewModel(Window window) : base(window) { }

        #region Properties
        public string Title { get; set; } = "Dialog Window";
        public Control Content { get; set; }
        #endregion
    }
}
