using System.Windows;

namespace MedicalRecordsApp
{
    public partial class PatientDiagnosisWindow : Window
    {
        public string PatientName { get; set; }
        public int PatientAge { get; set; }
        public string PatientDiagnosis { get; private set; }

        public PatientDiagnosisWindow(string name, int age, string diagnosis)
        {
            InitializeComponent();
            PatientName = name;
            PatientAge = age;
            PatientDiagnosis = diagnosis;

            PatientNameTextBox.Text = PatientName;
            PatientAgeTextBox.Text = PatientAge.ToString();
            PatientDiagnosisTextBox.Text = PatientDiagnosis;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PatientDiagnosisTextBox.Text))
            {
                MessageBox.Show("Поле \"Диагноз\" не может быть пустым.", "Ошибка");
                return;
            }

            PatientDiagnosis = PatientDiagnosisTextBox.Text;
            DialogResult = true;
            Close();
        }
    }
}
