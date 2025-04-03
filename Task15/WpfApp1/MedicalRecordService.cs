using System.Collections.Generic;
using System.Threading.Tasks;
using MedicalRecordsApp.Models;

namespace MedicalRecordsApp.Services
{
    public class MedicalRecordService
    {
        public async Task<List<MedicalRecordModel>> LoadMedicalRecordsAsync()
        {
            await Task.Delay(2000); 
            return new List<MedicalRecordModel>
            {
                new MedicalRecordModel
                {
                    PatientId = 1,
                    Diagnosis = "Flu",
                    Treatment = "Rest and hydration",
                    DateOfRecord = "2025-04-01"
                },
                new MedicalRecordModel
                {
                    PatientId = 2,
                    Diagnosis = "Hypertension",
                    Treatment = "Medication",
                    DateOfRecord = "2025-03-25"
                }
            };
        }
    }
}
