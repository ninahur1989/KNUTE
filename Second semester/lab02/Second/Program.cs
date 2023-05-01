using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Second
{
    class Program
    {
        static void Main()
        {
            // Read employee data from a file
            string filePath = "employees.csv";
            List<Employee> employees = File.ReadAllLines(filePath)
                .Select(line => new Employee(line.Split(',')[0], int.Parse(line.Split(',')[1])))
                .ToList();

            // Sort the employees by their salary
            employees = employees.OrderBy(e => e.Salary).ToList();

            // Print the sorted list of employees
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name}, {employee.Salary}");
            }
        }
    }
}