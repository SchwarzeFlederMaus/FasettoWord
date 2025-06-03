namespace FasettoWordCore
{
    public class ChatMessageListItemViewModel : BaseViewModel
    {
        public string SenderName { get; set; }
        public string Message { get; set; }
        public string Initials { get; set; }
        /// <summary>
        /// RGB color of the profile picture in hex format
        /// For example: ff0000 for red
        /// </summary>
        public string ProfilePictureRGB { get; set; }
        public bool IsSelected { get; set; }
        public bool IsSentByMe { get; set; }
        /// <summary>
        /// The time the message was sent
        /// </summary>
        public DateTimeOffset MessageSentTime { get; set; }
        /// <summary>
        /// The time the message was read, or <see cref="DateTimeOffset.MinValue"/> if it hasn't been read yet."/>
        /// </summary>
        public DateTimeOffset MessageReadTime { get; set; }
        public bool IsRead => MessageReadTime > DateTimeOffset.MinValue;
    }
}
