using MedicalRecordsApp.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MedicalRecordsApp.Services
{
    public class UserService
    {
        private readonly string _userFilePath = "users.json";

        public async Task<List<UserModel>> LoadUsersAsync()
        {
            if (!File.Exists(_userFilePath))
                return new List<UserModel>();
            string json = File.ReadAllText(_userFilePath);
            return JsonConvert.DeserializeObject<List<UserModel>>(json) ?? new List<UserModel>();
        }

        public async Task SaveUsersAsync(List<UserModel> users)
        {
            string json = File.ReadAllText(_userFilePath); 
            File.WriteAllText(_userFilePath, json);       
        }

        public async Task<bool> RegisterUserAsync(UserModel user)
        {
            var users = await LoadUsersAsync();
            if (users.Exists(u => u.Username == user.Username))
                return false;
            users.Add(user);
            await SaveUsersAsync(users);
            return true;
        }

        public async Task<UserModel> AuthenticateUserAsync(string username, string password)
        {
            var users = await LoadUsersAsync();
            return users.Find(u => u.Username == username && u.Password == password);
        }
    }
}
