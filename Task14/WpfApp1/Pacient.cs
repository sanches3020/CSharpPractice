using System.Collections.ObjectModel;
using System;

public class Patient
{
    public string FullName { get; set; }
    public int Age { get; set; }
    public string Diagnosis { get; set; }
    public ObservableCollection<MedicalRecord> MedicalRecords { get; set; } = new ObservableCollection<MedicalRecord>();
}

public class MedicalRecord
{
    public DateTime VisitDate { get; set; }
    public string Notes { get; set; }
}