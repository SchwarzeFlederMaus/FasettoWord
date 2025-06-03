using FasettoWordCore.DataModels;

namespace FasettoWordCore
{
    public class BasePopupViewModel : BaseViewModel
    {
        public BasePopupViewModel()
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
        public BaseViewModel Content { get; set; }
        #endregion
    }
}
