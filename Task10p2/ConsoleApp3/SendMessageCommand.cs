namespace ConsoleApp3
{
    public class SendMessageCommand : ICommand
    {
        private readonly ChatService _chatService;
        private readonly string _message;

        public SendMessageCommand(ChatService chatService, string message)
        {
            _chatService = chatService;
            _message = message;
        }

        public void Execute()
        {
            _chatService.SendMessage(_message);
        }
    }
}