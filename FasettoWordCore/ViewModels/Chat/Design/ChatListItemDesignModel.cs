namespace FasettoWordCore
{
    public class ChatListItemDesignModel : ChatListItemViewModel
    {
        public ChatListItemDesignModel()
        {
            Initials = "IP";
            Name = "UserName";
            LastMessage = "This is a last message";
            ProfilePictureRGB = "3099c5";
        }

        public static ChatListItemDesignModel Instance => new();
    }
}
