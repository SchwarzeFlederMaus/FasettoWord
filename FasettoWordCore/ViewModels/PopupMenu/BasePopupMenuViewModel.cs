using FasettoWordCore.DataModels;

namespace FasettoWordCore.ViewModels
{
    public class BasePopupMenuViewModel : BaseViewModel
    {
        public BasePopupMenuViewModel()
        {
            PopupBackground = "ffffff";
            ArrowAlignment = ElementHorizontalAligment.Left;
        }

        #region Properties
        /// <summary>
        /// Using string as ARGB color code
        /// </summary>
        public string PopupBackground { get; set; }
        public ElementHorizontalAligment ArrowAlignment { get; set; }
        #endregion
    }
}
