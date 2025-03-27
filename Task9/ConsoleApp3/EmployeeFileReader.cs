using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp3
{
    public class EmployeeFileReader
    {
        private const string FilePath = @"file.data";

        public List<Employee> ReadEmployees()
        {
            List<Employee> employees = new List<Employee>();

            try
            {
                using (StreamReader reader = new StreamReader(FilePath))
                {
             
                    string header = reader.ReadLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            var parts = line.Split(',');
                            if (parts.Length == 3 &&
                                decimal.TryParse(parts[2], out decimal salary))
                            {
                                employees.Add(new Employee(parts[0], parts[1], salary));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }

            return employees;
        }
    }
}