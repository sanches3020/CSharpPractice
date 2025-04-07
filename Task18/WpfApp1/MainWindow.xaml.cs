using System.Windows;
using MedicalRecordsApp.Services;

namespace SQLiteExample
{
    public partial class MainWindow : Window
    {
        private readonly DatabaseManager _databaseManager;

        public MainWindow()
        {
            InitializeComponent();

            _databaseManager = new DatabaseManager("medical.db");
        }

        private void CheckConnection_Click(object sender, RoutedEventArgs e)
        {
            bool isConnected = _databaseManager.CheckConnection();

            if (isConnected)
            {
                MessageBox.Show("Подключение успешно!", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Ошибка подключения.", "Результат", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
