using System.Collections.Generic;

namespace MedicalRecordsApp.Models
{
    public class MedicalData
    {
        public List<PatientModel> Patients { get; set; } = new List<PatientModel>();
        public List<AppointmentModel> Appointments { get; set; } = new List<AppointmentModel>();
    }
}
