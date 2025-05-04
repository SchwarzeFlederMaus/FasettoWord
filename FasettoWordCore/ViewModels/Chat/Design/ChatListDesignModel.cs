namespace FasettoWordCore.ViewModels
{
    public class ChatListDesignModel : ChatListViewModel
    {
        public ChatListDesignModel()
        {
            Items =
            [
                new() { 
                    Name = "Ihor",
                    Initials = "IP",
                    LastMessage = "This is a last message",
                    ProfilePictureRGB = "3099c5",
                    NewContentAvailable = true
                },
                new() {
                    Name = "Luke",
                    Initials = "LM",
                    LastMessage = "This chat is awesome! I bet it will be fast too",
                    ProfilePictureRGB = "fe4503"
                },
                new() {
                    Name = "Jesse",
                    Initials = "JA",
                    LastMessage = "Hey dude, here are the new icons",
                    ProfilePictureRGB = "00d405",
                    IsSelected = true
                },
                new() {
                    Name = "Ihor",
                    Initials = "IP",
                    LastMessage = "This is a last message",
                    ProfilePictureRGB = "3099c5"
                },
                new() {
                    Name = "Luke",
                    Initials = "LM",
                    LastMessage = "This chat is awesome! I bet it will be fast too",
                    ProfilePictureRGB = "fe4503"
                },
                new() {
                    Name = "Jesse",
                    Initials = "JA",
                    LastMessage = "Hey dude, here are the new icons",
                    ProfilePictureRGB = "00d405"
                },
                new() {
                    Name = "Ihor",
                    Initials = "IP",
                    LastMessage = "This is a last message",
                    ProfilePictureRGB = "3099c5"
                },
                new() {
                    Name = "Luke",
                    Initials = "LM",
                    LastMessage = "This chat is awesome! I bet it will be fast too",
                    ProfilePictureRGB = "fe4503"
                },
                new() {
                    Name = "Jesse",
                    Initials = "JA",
                    LastMessage = "Hey dude, here are the new icons",
                    ProfilePictureRGB = "00d405"
                },
            ];
        }

        public static ChatListDesignModel Instance => new();
    }
}
