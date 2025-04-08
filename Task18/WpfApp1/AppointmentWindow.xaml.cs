using MedicalRecordsApp.Models;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace MedicalRecordsApp.Views
{
    public partial class AppointmentWindow : Window
    {
        public AppointmentModel NewAppointment { get; set; }

        public AppointmentWindow()
        {
            InitializeComponent();
            NewAppointment = new AppointmentModel();
        }

        public AppointmentWindow(AppointmentModel appointment) : this()
        {
            NewAppointment = new AppointmentModel
            {
                ID = appointment.ID,
                Date = appointment.Date,
                DoctorName = appointment.DoctorName,
                PatientName = appointment.PatientName,
                Notes = appointment.Notes,
                Status = appointment.Status
            };

            DateTextBox.Text = NewAppointment.Date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            DoctorTextBox.Text = NewAppointment.DoctorName;
            PatientTextBox.Text = NewAppointment.PatientName;
            NotesTextBox.Text = NewAppointment.Notes;

            foreach (ComboBoxItem item in StatusComboBox.Items)
            {
                if (item.Content.ToString() == NewAppointment.Status)
                {
                    StatusComboBox.SelectedItem = item;
                    break;
                }
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DateTextBox.Text) ||
                string.IsNullOrWhiteSpace(DoctorTextBox.Text) ||
                string.IsNullOrWhiteSpace(PatientTextBox.Text) ||
                StatusComboBox.SelectedItem == null)
            {
                MessageBox.Show("Заполните все поля!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!DateTime.TryParseExact(DateTextBox.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                MessageBox.Show("Введите корректную дату в формате yyyy-MM-dd!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            NewAppointment.Date = date;
            NewAppointment.DoctorName = DoctorTextBox.Text.Trim();
            NewAppointment.PatientName = PatientTextBox.Text.Trim();
            NewAppointment.Notes = NotesTextBox.Text.Trim();
            NewAppointment.Status = (StatusComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
