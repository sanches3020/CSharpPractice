using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace MedicalRecordsApp
{
    public partial class MainWindow : Window
    {
        
        public ObservableCollection<Patient> Patients { get; set; }

        public ICommand RegisterPatientCommand { get; }
        public ICommand EditRecordCommand { get; }
        public ICommand DeleteRecordCommand { get; }

        public MainWindow()
        {
            InitializeComponent();

            Patients = new ObservableCollection<Patient>(); 

            RegisterPatientCommand = new RelayCommand(RegisterPatient);
            EditRecordCommand = new RelayCommand(EditRecord);
            DeleteRecordCommand = new RelayCommand(DeleteRecord);

            DataContext = this; 
        }

        private void ExitMenu_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void RegisterPatient(object parameter)
        {
            var registerWindow = new RegisterPatientWindow();
            if (registerWindow.ShowDialog() == true)
            {
              
                Patients.Add(new Patient
                {
                    Name = registerWindow.PatientName,
                    Age = registerWindow.PatientAge,
                    History = registerWindow.PatientHistory
                });
            }
        }

        private void EditRecord(object parameter)
        {
            MessageBox.Show("Форма для редактирования записи.", "Редактирование записи");
        }

        private void DeleteRecord(object parameter)
        {
            if (PatientsDataGrid.SelectedItem is Patient selectedPatient)
            {
                var result = MessageBox.Show($"Вы уверены, что хотите удалить запись пациента '{selectedPatient.Name}'?", "Подтверждение удаления", MessageBoxButton.YesNo);
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
    }

    public class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string History { get; set; }
    }
}
