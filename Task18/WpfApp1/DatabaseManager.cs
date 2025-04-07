using Microsoft.Data.Sqlite;
using System;
using System.IO;

namespace MedicalRecordsApp.Services
{
    public class DatabaseManager
    {
        private readonly string _dbPath;

        public DatabaseManager(string dbName)
        {
       
            _dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dbName);
            object value = SQLitePCL.Batteries.Init();
            CreateDatabase();
        }

        public bool CheckConnection()
        {
            try
            {
                using (var connection = new SqliteConnection($"Data Source={_dbPath};"))
                {
                    connection.Open();
                    Console.WriteLine("Соединение успешно установлено.");
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка соединения: {ex.Message}");
                return false;
            }
        }

        private void CreateDatabase()
        {
            if (!File.Exists(_dbPath))
            {
                Console.WriteLine("Создаётся база данных...");
                using (var connection = new SqliteConnection($"Data Source={_dbPath};"))
                {
                    connection.Open();
                }
                Console.WriteLine("База данных создана!");
                CreateTables();
            }
            else
            {
                Console.WriteLine("База данных уже существует.");
            }
        }

        private void CreateTables()
        {
            using (var connection = new SqliteConnection($"Data Source={_dbPath};"))
            {
                connection.Open();

                string createPatientsTableQuery = @"
                CREATE TABLE IF NOT EXISTS Patients (
                    Id INTEGER PRIMARY KEY,
                    Name TEXT NOT NULL,
                    BirthDate TEXT
                );";

                string createRecordsTableQuery = @"
                CREATE TABLE IF NOT EXISTS Records (
                    Id INTEGER PRIMARY KEY,
                    PatientId INTEGER NOT NULL,
                    Diagnosis TEXT,
                    RecordDate TEXT,
                    FOREIGN KEY(PatientId) REFERENCES Patients(Id)
                );";

                using (var command = new SqliteCommand(createPatientsTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Таблица 'Patients' успешно создана или уже существует.");
                }

                using (var command = new SqliteCommand(createRecordsTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Таблица 'Records' успешно создана или уже существует.");
                }
            }
        }
    }
}
