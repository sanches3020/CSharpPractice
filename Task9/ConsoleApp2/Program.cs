using System;
using System.Collections.Generic;
using ConsoleApp2;

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee("Alice", "Developer", 60000),
            new Employee("Bob", "Manager", 75000),
            new Employee("Charlie", "Designer", 50000)
        };

        EmployeeFileWriter.WriteEmployeesWithHeader(employees);

        Console.WriteLine("Данные успешно записаны в file.data");
    }
}