using System.Collections.Generic;

namespace MedicalRecordsApp
{
    public class Patient
    {
        public string Name { get; set; }
        public List<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();
    }
}