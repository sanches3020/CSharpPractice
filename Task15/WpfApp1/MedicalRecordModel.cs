namespace MedicalRecordsApp.Models
{
    public class MedicalRecordModel
    {
        public int PatientId { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string DateOfRecord { get; set; }
    }
}
