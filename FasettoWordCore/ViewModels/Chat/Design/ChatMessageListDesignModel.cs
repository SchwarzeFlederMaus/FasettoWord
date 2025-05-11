namespace FasettoWordCore.ViewModels
{
    public class ChatMessageListDesignModel : ChatMessageListViewModel
    {
        public ChatMessageListDesignModel()
        {
            Items =
            [
                new() {
                    SenderName = "Bohdan",
                    Initials = "BB",
                    Message = "Is it your new chat?",
                    ProfilePictureRGB = "fe4503",
                    MessageSentTime = DateTimeOffset.UtcNow.AddHours(-1),
                    IsSentByMe = false,
                },
                new() { 
                    SenderName = "Ihor",
                    Initials = "IP",
                    Message = "This is chat message bubble text. How do you think, is it OK?",
                    ProfilePictureRGB = "3099c5",
                    MessageSentTime = DateTimeOffset.UtcNow.AddMinutes(-45),
                    MessageReadTime = DateTimeOffset.UtcNow.AddMinutes(-30),
                    IsSentByMe = true,
                },
                new() {
                    SenderName = "Bohdan",
                    Initials = "BB",
                    Message = "It's realy cool. Good job!",
                    ProfilePictureRGB = "fe4503",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    IsSentByMe = false,
                },
            ];
        }

        public static ChatMessageListDesignModel Instance => new();
    }
}
