using System;

namespace MedicalRecordsApp.Models
{
    public class AppointmentModel
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
    }
}
