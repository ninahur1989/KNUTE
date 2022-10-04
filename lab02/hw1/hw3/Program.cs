using System;
using System.Reflection;

namespace hw3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("fdf", "dsd");
            Console.WriteLine($"{employee._name} {employee._surname} {employee._experience} {employee.Role} {employee.Handouts} {employee.Salary}");
            Console.ReadLine();
            Console.WriteLine(  employee.Koood);

            
        }
    }
}
