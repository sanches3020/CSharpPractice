namespace ConsoleApp3
{
    public class ChatClient
    {
        private ICommand _command;
        public void SetCommand(ICommand command)
        {
            _command = command;
        }
        public void Send()
        {
            _command.Execute();
        }
    }
}