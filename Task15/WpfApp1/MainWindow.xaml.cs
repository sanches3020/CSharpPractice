using System.Windows;
using MedicalRecordsApp.ViewModels;

namespace MedicalRecordsApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MedicalRecordsViewModel();
        }
    }
}
