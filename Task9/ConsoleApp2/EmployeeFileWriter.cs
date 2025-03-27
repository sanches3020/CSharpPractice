using System.Collections.Generic;
using System.IO;

namespace ConsoleApp2
{
    public class EmployeeFileWriter
    {
        private const string FilePath = @"file.data";

        public static void WriteEmployeesWithHeader(List<Employee> employees)
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                writer.WriteLine("Name,Position,Salary");

                foreach (var employee in employees)
                {
                    writer.WriteLine($"{employee.Name},{employee.Position},{employee.Salary}");
                }
            }
        }
    }
}