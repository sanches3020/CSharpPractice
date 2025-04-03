using System.Windows;

namespace MedicalRecordsApp
{
    public partial class RegisterPatientWindow : Window
    {
        public string PatientName { get; private set; }
        public int PatientAge { get; private set; }
        public string PatientHistory { get; private set; }
        public string PatientDiagnosis { get; internal set; }

        public RegisterPatientWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            PatientName = NameTextBox.Text;

            if (!int.TryParse(AgeTextBox.Text, out int age))
            {
                MessageBox.Show("Пожалуйста, введите корректный возраст.", "Ошибка");
                return;
            }
            PatientAge = age;

            PatientHistory = HistoryTextBox.Text;

            DialogResult = true; 
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
