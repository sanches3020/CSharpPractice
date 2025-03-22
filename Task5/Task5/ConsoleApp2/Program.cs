using ConsoleApp2;
using System;

namespace HospitalManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor[] doctors = { new Doctor("Dr. Smith"), new Doctor("Dr. Johnson") };
            Pharmacy pharmacy = new Pharmacy("City Pharmacy");
            Hospital hospital = new Hospital(doctors, pharmacy);
            Patient[] patients = { new Patient("Alice"), new Patient("Bob") };

            hospital.TreatPatients(patients);
        }
    }
}