using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;
using MedicalRecordsApp.Models;
using Microsoft.Data.Sqlite;

namespace MedicalRecordsApp.Repositories
{
    public class PatientRepository
    {
        private readonly string _connectionString;

        public PatientRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<Patient>> GetAllAsync()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var patients = new List<Patient>();

                string query = "SELECT * FROM Patients;";
                using (var command = new SqliteCommand(query, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (reader.Read())
                        {
                            patients.Add(new Patient
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                BirthDate = reader.GetString(2)
                            });
                        }
                    }
                }

                return patients;
            }
        }

        public async Task AddAsync(Patient patient)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Patients (Name, BirthDate) VALUES (@Name, @BirthDate);";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", patient.Name);
                    command.Parameters.AddWithValue("@BirthDate", patient.BirthDate);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task UpdateAsync(Patient patient)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                string query = "UPDATE Patients SET Name = @Name, BirthDate = @BirthDate WHERE Id = @Id;";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", patient.Name);
                    command.Parameters.AddWithValue("@BirthDate", patient.BirthDate);
                    command.Parameters.AddWithValue("@Id", patient.Id);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Patients WHERE Id = @Id;";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
