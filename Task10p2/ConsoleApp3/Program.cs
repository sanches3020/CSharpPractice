using ConsoleApp3;

class Program
{
    static void Main(string[] args)
    {
        ChatService chatService = new ChatService();
        ICommand command = new SendMessageCommand(chatService, "Доброго полудня!");

        ChatClient client = new ChatClient();
        client.SetCommand(command);
        client.Send();
    }
}