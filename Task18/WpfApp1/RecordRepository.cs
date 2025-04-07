using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;
using MedicalRecordsApp.Models;
using Microsoft.Data.Sqlite;

namespace MedicalRecordsApp.Repositories
{
    public class RecordRepository
    {
        private readonly string _connectionString;

        public RecordRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<Record>> GetAllAsync()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var records = new List<Record>();

                string query = "SELECT * FROM Records;";
                using (var command = new SqliteCommand(query, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (reader.Read())
                        {
                            records.Add(new Record
                            {
                                Id = reader.GetInt32(0),
                                PatientId = reader.GetInt32(1),
                                Diagnosis = reader.GetString(2),
                                RecordDate = reader.GetString(3)
                            });
                        }
                    }
                }

                return records;
            }
        }

        public async Task AddAsync(Record record)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Records (PatientId, Diagnosis, RecordDate) VALUES (@PatientId, @Diagnosis, @RecordDate);";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientId", record.PatientId);
                    command.Parameters.AddWithValue("@Diagnosis", record.Diagnosis);
                    command.Parameters.AddWithValue("@RecordDate", record.RecordDate);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task UpdateAsync(Record record)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                string query = "UPDATE Records SET PatientId = @PatientId, Diagnosis = @Diagnosis, RecordDate = @RecordDate WHERE Id = @Id;";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientId", record.PatientId);
                    command.Parameters.AddWithValue("@Diagnosis", record.Diagnosis);
                    command.Parameters.AddWithValue("@RecordDate", record.RecordDate);
                    command.Parameters.AddWithValue("@Id", record.Id);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Records WHERE Id = @Id;";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
