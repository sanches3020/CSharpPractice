using System;
using System.Collections.Generic;
using ConsoleApp3;

class Program
{
    static void Main()
    {

        EmployeeFileReader reader = new EmployeeFileReader();
        List<Employee> employees = reader.ReadEmployees();

        Console.WriteLine("Введите минимальную зарплату для фильтрации:");
        decimal minSalary;

        if (decimal.TryParse(Console.ReadLine(), out minSalary))
        {
            EmployeeProcessor processor = new EmployeeProcessor();
            List<Employee> filteredEmployees = processor.FilterBySalary(employees, minSalary);

            Console.WriteLine("Сотрудники с зарплатой выше указанной:");
            foreach (var employee in filteredEmployees)
            {
                Console.WriteLine($"{employee.Name}, {employee.Position}, {employee.Salary}");
            }
        }
        else
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите число.");
        }
    }
}