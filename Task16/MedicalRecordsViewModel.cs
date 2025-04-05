using MedicalRecordsApp.Models;
using MedicalRecordsApp.Services;
using MedicalRecordsApp.Commands;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MedicalRecordsApp.ViewModels
{
    public class MedicalRecordsViewModel : ViewModelBase
    {
        private readonly DataStoreService _dataStore;
        private readonly NotificationService _notificationService;

        public ObservableCollection<PatientModel> Patients { get; set; }
        public ObservableCollection<AppointmentModel> Appointments { get; set; }

        private AppointmentModel _selectedAppointment;
        public AppointmentModel SelectedAppointment
        {
            get => _selectedAppointment;
            set { _selectedAppointment = value; OnPropertyChanged(nameof(SelectedAppointment)); }
        }

        public ICommand AddAppointmentCommand { get; }
        public ICommand EditAppointmentCommand { get; }
        public ICommand DeleteAppointmentCommand { get; }

        public bool IsProcessing { get; set; }

        public MedicalRecordsViewModel()
        {
            _dataStore = new DataStoreService();
            _notificationService = new NotificationService();
            Patients = new ObservableCollection<PatientModel>();
            Appointments = new ObservableCollection<AppointmentModel>();

            AddAppointmentCommand = new RelayCommand(async _ => await AddAppointmentAsync(), _ => !IsProcessing);
            EditAppointmentCommand = new RelayCommand(async _ => await EditAppointmentAsync(), _ => SelectedAppointment != null && !IsProcessing);
            DeleteAppointmentCommand = new RelayCommand(async _ => await DeleteAppointmentAsync(), _ => SelectedAppointment != null && !IsProcessing);

            LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            var data = await _dataStore.LoadMedicalDataAsync();
            foreach (var patient in data.Patients)
                Patients.Add(patient);
            foreach (var appointment in data.Appointments)
                Appointments.Add(appointment);
        }

        private async Task AddAppointmentAsync()
        {
            var window = new Views.AppointmentWindow();
            window.Owner = Application.Current.MainWindow;
            if (window.ShowDialog() == true && window.NewAppointment != null)
            {
                var newAppt = window.NewAppointment;
                newAppt.ID = Appointments.Count + 1;
                Appointments.Add(newAppt);
                await SaveDataAsync();
                _notificationService.WriteNotification($"Новый прием: {newAppt.ID} - {newAppt.DoctorName} с {newAppt.PatientName}");
                MessageBox.Show("Прием добавлен!");
            }
        }

        private async Task EditAppointmentAsync()
        {
            if (SelectedAppointment == null)
            {
                MessageBox.Show("Выберите прием для редактирования!");
                return;
            }
            var window = new Views.AppointmentWindow(SelectedAppointment);
            window.Owner = Application.Current.MainWindow;
            if (window.ShowDialog() == true)
            {
                await SaveDataAsync();
                MessageBox.Show("Прием отредактирован!");
            }
        }

        private async Task DeleteAppointmentAsync()
        {
            if (SelectedAppointment == null)
            {
                MessageBox.Show("Выберите прием для удаления!");
                return;
            }
            if (MessageBox.Show("Удалить выбранный прием?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Appointments.Remove(SelectedAppointment);
                await SaveDataAsync();
                MessageBox.Show("Прием удален!");
            }
        }

        private async Task SaveDataAsync()
        {
            var data = new MedicalData
            {
                Patients = new List<PatientModel>(Patients),
                Appointments = new List<AppointmentModel>(Appointments)
            };
            await _dataStore.SaveMedicalDataAsync(data);
        }
    }
}
