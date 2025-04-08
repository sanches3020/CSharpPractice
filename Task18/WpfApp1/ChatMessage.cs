using System;

namespace MedicalRecordsApp.Models
{
    public class ChatMessage
    {
        public string FirstWord { get; set; }
        public string SecondWord { get; set; }
        public DateTime Timestamp { get; set; }

        public override string ToString()
        {
            return $"{FirstWord} {SecondWord}";
        }
    }
}
