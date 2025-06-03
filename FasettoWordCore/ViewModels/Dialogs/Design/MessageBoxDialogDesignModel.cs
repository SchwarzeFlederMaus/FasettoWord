namespace FasettoWordCore
{
    public class MessageBoxDialogDesignModel : MessageBoxDialogViewModel
    {
        public static MessageBoxDialogDesignModel Instance => new() 
        { 
            Title = "Dessign Time Title",
            Message = "This is a design time message for the MessageBoxDialog.",
            OkButtonText = "OK"
        };
    }
}
