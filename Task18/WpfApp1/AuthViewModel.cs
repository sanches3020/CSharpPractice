using MedicalRecordsApp.Models;
using MedicalRecordsApp.Services;
using MedicalRecordsApp.Commands;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MedicalRecordsApp.ViewModels
{
    public class AuthViewModel : ViewModelBase
    {
        private readonly UserService _userService;

        public string Username { get; set; }
        public string Password { get; set; }
  
        public string Role { get; set; }

        public ICommand LoginCommand { get; }
        public ICommand RegisterCommand { get; }

        public AuthViewModel()
        {
            _userService = new UserService();
            LoginCommand = new RelayCommand(async _ => await LoginAsync());
            RegisterCommand = new RelayCommand(async _ => await RegisterAsync());
        }

        private async Task LoginAsync()
        {
            var user = await _userService.AuthenticateUserAsync(Username, Password);
            if (user != null)
            {
                MessageBox.Show($"Вход выполнен успешно. Роль: {user.Role}");
             
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль");
            }
        }

        private async Task RegisterAsync()
        {
            if (string.IsNullOrWhiteSpace(Role))
            {
                MessageBox.Show("Укажите роль (Doctor или Patient)");
                return;
            }

            var newUser = new UserModel
            {
                Username = Username,
                Password = Password, 
                Role = Role
            };

            bool success = await _userService.RegisterUserAsync(newUser);
            if (success)
            {
                MessageBox.Show("Регистрация прошла успешно");
            }
            else
            {
                MessageBox.Show("Пользователь с таким именем уже существует");
            }
        }
    }
}
