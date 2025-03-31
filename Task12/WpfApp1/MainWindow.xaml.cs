using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace MedicalRecordsApp
{
    public partial class MainWindow : Window
    {
        private List<Patient> patients = new List<Patient>();

        public MainWindow()
        {
            InitializeComponent();
            LoadPatients();
        }

        private void LoadPatients()
        {
            patients.Add(new Patient { Name = "Иван Иванов" });
            patients.Add(new Patient { Name = "Петр Петров" });
            patients.Add(new Patient { Name = "Мария Сидорова" });

            PatientsListBox.ItemsSource = patients; 
        }

        private void PatientsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PatientsListBox.SelectedItem is Patient selectedPatient)
            {
                MedicalHistoryDataGrid.ItemsSource = selectedPatient.MedicalRecords; 
            }
        }

        private void AddRecordButton_Click(object sender, RoutedEventArgs e)
        {
            if (PatientsListBox.SelectedItem is Patient selectedPatient)
            {
                var record = new MedicalRecord
                {
                    Date = DateTime.Now,
                    Diagnosis = "Новый диагноз",
                    Description = "Описание истории болезни"
                };

                selectedPatient.MedicalRecords.Add(record); 
                MedicalHistoryDataGrid.ItemsSource = null;
                MedicalHistoryDataGrid.ItemsSource = selectedPatient.MedicalRecords; 
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите пациента для добавления записи.");
            }
        }

        private void MedicalHistoryDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}