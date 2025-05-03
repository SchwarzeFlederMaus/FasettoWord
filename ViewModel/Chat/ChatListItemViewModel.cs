namespace FasettoWord.ViewModel
{
    public class ChatListItemViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string LastMessage { get; set; }
        public string Initials { get; set; }
        /// <summary>
        /// RGB color of the profile picture in hex format
        /// For example: ff0000 for red
        /// </summary>
        public string ProfilePictureRGB { get; set; }
        public bool NewContentAvailable { get; set; }
        public bool IsSelected { get; set; }
    }
}
