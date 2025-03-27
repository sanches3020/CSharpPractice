using ConsoleApp3;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class EmployeeProcessor
    {
        public List<Employee> FilterBySalary(List<Employee> employees, decimal minSalary)
        {
            return employees.Where(e => e.Salary >= minSalary).ToList();
        }
    }
}