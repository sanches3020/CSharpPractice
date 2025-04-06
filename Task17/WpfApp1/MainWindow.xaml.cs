using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

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

        private void MainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            var sb = (Storyboard)this.Resources["FadeInAnimation"];
            sb.Begin(MainGrid);
        }

        private void ShowDiagnosis(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var parent = button.Parent as StackPanel;
            var diagnosis = parent.FindName("Diagnosis1") as TextBlock;

            if (diagnosis != null)
            {
                diagnosis.Visibility = Visibility.Visible;

                var sb = (Storyboard)this.Resources["SlideInAnimation"];
                sb.Begin(diagnosis); 
            }
        }
    }
}
