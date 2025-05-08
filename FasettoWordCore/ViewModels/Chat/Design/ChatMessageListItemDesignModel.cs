namespace FasettoWordCore.ViewModels
{
    public class ChatMessageListItemDesignModel : ChatMessageListItemViewModel
    {
        public ChatMessageListItemDesignModel()
        {
            Initials = "IP";
            Name = "UserName";
            Message = "This is chat message bubble text. How do you think, is it OK?";
            ProfilePictureRGB = "3099c5";
        }

        public static ChatMessageListItemDesignModel Instance => new();
    }
}
