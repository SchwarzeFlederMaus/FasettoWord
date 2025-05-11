namespace FasettoWordCore.ViewModels
{
    public class ChatMessageListItemDesignModel : ChatMessageListItemViewModel
    {
        public ChatMessageListItemDesignModel()
        {
            Initials = "IP";
            SenderName = "UserName";
            Message = "Some message for designTime mode!";
            ProfilePictureRGB = "3099c5";
            MessageSentTime = DateTimeOffset.UtcNow;
            IsSentByMe = true;
        }

        public static ChatMessageListItemDesignModel Instance => new();
    }
}
