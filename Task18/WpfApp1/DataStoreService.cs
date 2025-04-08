using MedicalRecordsApp.Models;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MedicalRecordsApp.Services
{
    public class DataStoreService
    {
        private readonly string _dataFilePath = "medical.json";

        public async Task SaveMedicalDataAsync(MedicalData data)
        {
            string json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);

            using (var writer = new StreamWriter(_dataFilePath, false, Encoding.UTF8))
            {
                await writer.WriteAsync(json);
            }
        }

        public async Task<MedicalData> LoadMedicalDataAsync()
        {
            if (!File.Exists(_dataFilePath))
                return new MedicalData();

            using (var reader = new StreamReader(_dataFilePath, Encoding.UTF8))
            {
                string json = await reader.ReadToEndAsync();
                return JsonConvert.DeserializeObject<MedicalData>(json) ?? new MedicalData();
            }
        }
    }
}
