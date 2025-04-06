using MedicalRecordsApp.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.IO.Pipes;
using System.Threading.Tasks;

namespace MedicalRecordsApp.Services
{
    public class ChatService
    {
        private const string PipeName = "ChatPipe";

        public async Task SendMessageAsync(ChatMessage message)
        {
            try
            {
                using (var client = new NamedPipeClientStream(".", PipeName, PipeDirection.Out))
                {
                    await client.ConnectAsync(3000);
                    using (var writer = new StreamWriter(client))
                    {
                        writer.AutoFlush = true;
                        string json = JsonConvert.SerializeObject(message);
                        await writer.WriteLineAsync(json);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка отправки сообщения: {ex.Message}");
            }
        }

        public async Task ListenForMessagesAsync(Action<ChatMessage> onMessageReceived)
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    try
                    {
                        using (var server = new NamedPipeServerStream(PipeName, PipeDirection.In))
                        {
                            server.WaitForConnection();
                            using (var reader = new StreamReader(server))
                            {
                                string line = reader.ReadLine();
                                if (!string.IsNullOrEmpty(line))
                                {
                                    var message = JsonConvert.DeserializeObject<ChatMessage>(line);
                                    onMessageReceived?.Invoke(message);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка приема сообщения: {ex.Message}");
                    }
                }
            });
        }
    }
}
