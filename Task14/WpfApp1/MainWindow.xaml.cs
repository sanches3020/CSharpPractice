using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace MedicalRecordsApp
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Patient> Patients { get; set; }
        public DateTime? FilterDate { get; set; }
        public ICommand RegisterPatientCommand { get; }
        public ICommand EditRecordCommand { get; }
        public ICommand DeleteRecordCommand { get; }
        public ICommand AddRecordCommand { get; }
        public ICommand FilterCommand { get; }

        public MainWindow()
        {
            InitializeComponent();
            Patients = new ObservableCollection<Patient>();

            RegisterPatientCommand = new RelayCommand(RegisterPatient);
            EditRecordCommand = new RelayCommand(EditRecord);
            DeleteRecordCommand = new RelayCommand(DeleteRecord);
            AddRecordCommand = new RelayCommand(AddRecord);
            FilterCommand = new RelayCommand(FilterByDate);

            DataContext = this;
            InitializeSampleData(); // Инициализация данных
        }

        private void InitializeSampleData()
        {
            Patients.Add(new Patient { FullName = "Иванов И.И.", Age = 30, Diagnosis = "Острый фарингит", MedicalRecords = new ObservableCollection<MedicalRecord> { new MedicalRecord { VisitDate = DateTime.Now.AddDays(-10), Notes = "Первичный осмотр" } } });
            Patients.Add(new Patient { FullName = "Петров П.П.", Age = 45, Diagnosis = "Хронический бронхит", MedicalRecords = new ObservableCollection<MedicalRecord> { new MedicalRecord { VisitDate = DateTime.Now.AddDays(-20), Notes = "Повторный осмотр" } } });
        }
        private void ExitMenu_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void FilterByDate(object parameter)
        {
            if (FilterDate.HasValue)
            {
                var filteredPatients = Patients
                    .Where(p => p.MedicalRecords.Any(r => r.VisitDate.Date == FilterDate.Value.Date))
                    .ToList();

                Patients.Clear();
                foreach (var patient in filteredPatients)
                {
                    Patients.Add(patient);
                }
            }
            else
            {
                MessageBox.Show("Выберите дату для фильтрации!", "Ошибка");
            }
        }

        private void RegisterPatient(object parameter)
        {
            var registerWindow = new RegisterPatientWindow();
            if (registerWindow.ShowDialog() == true)
            {
                Patients.Add(new Patient
                {
                    FullName = registerWindow.PatientName,
                    Age = registerWindow.PatientAge,
                    Diagnosis = registerWindow.PatientDiagnosis,
                    MedicalRecords = new ObservableCollection<MedicalRecord>()
                });
            }
        }

        private void EditRecord(object parameter)
        {
            if (!(PatientsDataGrid.SelectedItem is Patient selectedPatient))
            {
                MessageBox.Show("Выберите пациента для редактирования.", "Ошибка");
            }
            else
            {
                MessageBox.Show($"Редактирование записи пациента: {selectedPatient.FullName}", "Редактирование записи");
            }
        }

        private void DeleteRecord(object parameter)
        {
            if (Patients.Count == 0)
            {
                MessageBox.Show("Список пациентов пуст.", "Ошибка");
                return;
            }

            if (PatientsDataGrid.SelectedItem is Patient selectedPatient)
            {
                var result = MessageBox.Show($"Вы уверены, что хотите удалить запись пациента '{selectedPatient.FullName}'?", "Подтверждение удаления", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    Patients.Remove(selectedPatient);
                }
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления.", "Ошибка");
            }
        }

        private void AddRecord(object parameter)
        {
            if (PatientsDataGrid.SelectedItem is Patient selectedPatient)
            {
                var record = new MedicalRecord { VisitDate = DateTime.Now, Notes = "Новая запись о приеме" };
                selectedPatient.MedicalRecords.Add(record);
                MessageBox.Show("Запись о приеме добавлена.", "Добавление записи");
            }
            else
            {
                MessageBox.Show("Выберите пациента для добавления записи.", "Ошибка");
            }
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.R && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
            {
                RegisterPatient(null);
            }
            else if (e.Key == Key.E && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
            {
                EditRecord(null);
            }
            else if (e.Key == Key.Delete)
            {
                DeleteRecord(null);
            }
            else if (e.Key == Key.A && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
            {
                AddRecord(null);
            }
        }
    }

    internal class PatientsDataGrid
    {
        public static Patient SelectedItem { get; internal set; }
    }

    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }

    public class Patient
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Diagnosis { get; set; }
        public ObservableCollection<MedicalRecord> MedicalRecords { get; set; } = new ObservableCollection<MedicalRecord>();

        public DateTime? LastVisitDate => MedicalRecords.OrderByDescending(r => r.VisitDate).FirstOrDefault()?.VisitDate;
    }

    public class MedicalRecord
    {
        public DateTime VisitDate { get; set; }
        public string Notes { get; set; }
    }
}
