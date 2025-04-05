using System.Windows;

namespace MedicalRecordsApp.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
          
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var loginWindow = new LoginWindow { Owner = this };
            loginWindow.ShowDialog();
        }

        private void OpenChat_Click(object sender, RoutedEventArgs e)
        {
            var chatWindow = new ChatWindow { Owner = this };
            chatWindow.Show();
        }
    }
}
