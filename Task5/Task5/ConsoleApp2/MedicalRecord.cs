using System;

namespace ConsoleApp2
{
    class MedicalRecord
    {
        public string Diagnosis { get; set; }
        public MedicalRecord(string diagnosis)
        {
            Diagnosis = diagnosis;
        }
    }
}