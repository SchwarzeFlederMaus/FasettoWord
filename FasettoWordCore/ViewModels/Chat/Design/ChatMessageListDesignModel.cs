namespace FasettoWordCore.ViewModels
{
    public class ChatMessageListDesignModel : ChatMessageListViewModel
    {
        public ChatMessageListDesignModel()
        {
            Items =
            [
                new() { 
                    Name = "Ihor",
                    Initials = "IP",
                    Message = "This is chat message bubble text. How do you think, is it OK?",
                    ProfilePictureRGB = "3099c5"
                },
                new() {
                    Name = "Luke",
                    Initials = "LM",
                    Message = "Yes, it's realy cool chat",
                    ProfilePictureRGB = "fe4503"
                },
                new() {
                    Name = "Ihor",
                    Initials = "IP",
                    Message = "This is chat message bubble text. How do you think, is it OK?",
                    ProfilePictureRGB = "3099c5"
                },
                new() {
                    Name = "Luke",
                    Initials = "LM",
                    Message = "Yes, it's realy cool chat",
                    ProfilePictureRGB = "fe4503"
                },
                new() {
                    Name = "Ihor",
                    Initials = "IP",
                    Message = "This is chat message bubble text. How do you think, is it OK?",
                    ProfilePictureRGB = "3099c5"
                },
                new() {
                    Name = "Luke",
                    Initials = "LM",
                    Message = "Yes, it's realy cool chat",
                    ProfilePictureRGB = "fe4503"
                },
                new() {
                    Name = "Ihor",
                    Initials = "IP",
                    Message = "This is chat message bubble text. How do you think, is it OK?",
                    ProfilePictureRGB = "3099c5"
                },
                new() {
                    Name = "Luke",
                    Initials = "LM",
                    Message = "Yes, it's realy cool chat",
                    ProfilePictureRGB = "fe4503"
                },
                new() {
                    Name = "Ihor",
                    Initials = "IP",
                    Message = "This is chat message bubble text. How do you think, is it OK?",
                    ProfilePictureRGB = "3099c5"
                },
                new() {
                    Name = "Luke",
                    Initials = "LM",
                    Message = "Yes, it's realy cool chat",
                    ProfilePictureRGB = "fe4503"
                },
            ];
        }

        public static ChatMessageListDesignModel Instance => new();
    }
}
