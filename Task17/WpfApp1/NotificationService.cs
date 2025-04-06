using System;
using System.IO.MemoryMappedFiles;
using System.Text;

namespace MedicalRecordsApp.Services
{
    public class NotificationService
    {
        private const string MapName = "MedicalNotifications";
        private const int MapSize = 1024;

        public void WriteNotification(string notification)
        {
            using (var mmf = MemoryMappedFile.CreateOrOpen(MapName, MapSize))
            using (var accessor = mmf.CreateViewAccessor())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(notification);
                accessor.Write(0, bytes.Length);
                accessor.WriteArray(4, bytes, 0, bytes.Length);
            }
        }

        public string ReadNotification()
        {
            using (var mmf = MemoryMappedFile.OpenExisting(MapName))
            using (var accessor = mmf.CreateViewAccessor())
            {
                int length = accessor.ReadInt32(0);
                byte[] bytes = new byte[length];
                accessor.ReadArray(4, bytes, 0, length);
                return Encoding.UTF8.GetString(bytes);
            }
        }
    }
}
