namespace MedicalRecordsApp.Models
{
    public class Record
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string Diagnosis { get; set; }
        public string RecordDate { get; set; }
    }
}
