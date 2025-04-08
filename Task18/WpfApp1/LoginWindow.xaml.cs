﻿using MedicalRecordsApp.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace MedicalRecordsApp.Views
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is AuthViewModel vm && sender is PasswordBox pb)
            {
                vm.Password = pb.Password;
            }
        }
    }
}
