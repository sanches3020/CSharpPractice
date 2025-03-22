using ConsoleApp2;
using System;

namespace ConsoleApp2
{
    public class Hospital
    {
        public Doctor[] Doctors { get; set; }
        private List<MedicalRecord> medicalRecords = new List<MedicalRecord>();
        public Pharmacy Pharmacy { get; set; }

        public Hospital(Doctor[] doctors, Pharmacy pharmacy)
        {
            Doctors = doctors;
            Pharmacy = pharmacy;
        }

        public void TreatPatients(Patient[] patients)
        {
            foreach (var patient in patients)
            {
                MedicalRecord record = new MedicalRecord("Диагностика для " + patient.Name);
                medicalRecords.Add(record);
                Console.WriteLine($"{patient.Name} лечится. Диагноз: {record.Diagnosis} at {Pharmacy.PharmacyName}");
            }
        }
    }
}
    