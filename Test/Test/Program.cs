// See https://aka.ms/new-console-template for more information
using EmployeeMS;
using HrLib;

Console.WriteLine("Hello, World!");

//Hrmanager: int id, string firstName, string lastName, double salary, string address,double bonus, int hoursWorked
//SalesManager: int id, string firstName, string lastName, int post, double salary, string address,double bonus
List<Employee> employees = new List<Employee>();

employees.Add(new HrManager(1, "a1", "b1", 50000, "Pune", 5000, 100));
employees.Add(new SalesManager(2, "a2", "b2", 45000, "Mumbai", 0));
employees.Add(new HrManager(3, "a3", "b3", 60000, "Delhi", 7000, 170));


foreach (var emp in employees)
{
    Console.WriteLine(emp + "\n");
}