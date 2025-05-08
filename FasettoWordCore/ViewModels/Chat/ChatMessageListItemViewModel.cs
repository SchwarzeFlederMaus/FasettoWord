namespace FasettoWordCore.ViewModels
{
    public class ChatMessageListItemViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Message { get; set; }
        public string Initials { get; set; }
        /// <summary>
        /// RGB color of the profile picture in hex format
        /// For example: ff0000 for red
        /// </summary>
        public string ProfilePictureRGB { get; set; }
    }
}
