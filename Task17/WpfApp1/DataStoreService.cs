using MedicalRecordsApp.Models;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace MedicalRecordsApp.Services
{
    public class DataStoreService
    {
        private readonly string _dataFilePath = "medical.json";

        public async Task SaveMedicalDataAsync(MedicalData data)
        {
          
            string json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
            await File.WriteAllTextAsync(_dataFilePath, json);
        }

        public async Task<MedicalData> LoadMedicalDataAsync()
        {
            if (!File.Exists(_dataFilePath))
                return new MedicalData();
            string json = await File.ReadAllTextAsync(_dataFilePath);
            return JsonConvert.DeserializeObject<MedicalData>(json) ?? new MedicalData();
        }
    }
}
