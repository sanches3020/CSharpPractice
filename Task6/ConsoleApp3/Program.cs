using System;

public delegate void MessageReceivedHandler(string message);

public class ChatApplication
{
    public event MessageReceivedHandler MessageReceived;

    public void SendMessage(string message)
    {
        Console.WriteLine($"Отправлено сообщение: {message}");
        OnMessageReceived(message);
    }

    protected virtual void OnMessageReceived(string message)
    {
        MessageReceived?.Invoke(message);
    }
}

public class DesktopNotifier
{
    public void OnMessageReceived(string message)
    {
        Console.WriteLine($"Всплывающее окно: Новое сообщение - {message}");
    }
}

public class SoundAlert
{
    public void OnMessageReceived(string message)
    {
        Console.Beep();
        Console.WriteLine($"Звуковое уведомление: Новое сообщение - {message}");
    }
}

class Program
{
    static void Main()
    {
        ChatApplication chatApp = new ChatApplication();
        DesktopNotifier desktopNotifier = new DesktopNotifier();
        SoundAlert soundAlert = new SoundAlert();

        chatApp.MessageReceived += desktopNotifier.OnMessageReceived;
        chatApp.MessageReceived += soundAlert.OnMessageReceived;

        chatApp.SendMessage("На ваш телефон пришло новое сообщение");
        chatApp.SendMessage("Посмотри его вдруг там что-то важное");
    }
}