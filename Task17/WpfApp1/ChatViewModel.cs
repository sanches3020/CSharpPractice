using MedicalRecordsApp.Commands;
using MedicalRecordsApp.Models;
using MedicalRecordsApp.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MedicalRecordsApp.ViewModels
{
    public class ChatViewModel : ViewModelBase
    {
        private readonly ChatService _chatService;
        public ObservableCollection<ChatMessage> Messages { get; set; }

        private string _firstInputWord;
        public string FirstInputWord
        {
            get => _firstInputWord;
            set { _firstInputWord = value; OnPropertyChanged(nameof(FirstInputWord)); }
        }

        private string _secondInputWord;
        public string SecondInputWord
        {
            get => _secondInputWord;
            set { _secondInputWord = value; OnPropertyChanged(nameof(SecondInputWord)); }
        }

        public ICommand SendMessageCommand { get; }

        public ChatViewModel()
        {
            _chatService = new ChatService();
            Messages = new ObservableCollection<ChatMessage>();
            SendMessageCommand = new RelayCommand(async _ => await SendMessageAsync());
            Task.Run(() => _chatService.ListenForMessagesAsync(OnMessageReceived));
        }

        private async Task SendMessageAsync()
        {
            if (string.IsNullOrWhiteSpace(FirstInputWord) || string.IsNullOrWhiteSpace(SecondInputWord))
                return;

            var message = new ChatMessage
            {
                FirstWord = FirstInputWord.Trim(),
                SecondWord = SecondInputWord.Trim(),
                Timestamp = System.DateTime.Now
            };

            try
            {
                await _chatService.SendMessageAsync(message);
            }
            catch { }

            Messages.Add(message);
            FirstInputWord = string.Empty;
            SecondInputWord = string.Empty;
            OnPropertyChanged(nameof(FirstInputWord));
            OnPropertyChanged(nameof(SecondInputWord));
        }

        private void OnMessageReceived(ChatMessage message)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                Messages.Add(message);
            });
        }
    }
}
