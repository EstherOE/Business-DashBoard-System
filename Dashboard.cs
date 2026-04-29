using System;
using System.Collections.Generic;
using System.Linq;
class Dashboard
{
  

public void ShowKPIs()
{
    var employees = DataStore.Employees;

    Console.WriteLine("\n--- KPI Summary ---");
    Console.WriteLine($"Total Staff: {employees.Count}");
    Console.WriteLine($"Active Staff: {employees.Count(e => e.Status == "Active")}");
    Console.WriteLine($"Departments: {employees.Select(e => e.Department).Distinct().Count()}");
    Console.WriteLine($"Total Salaries: ${employees.Sum(e => e.Salary)}");
}
    public void ShowDepartments()
    {
 Console.WriteLine("\n--- Departments ---");
       
 foreach (var emp in DataStore.Employees)
        {
           Console.WriteLine(emp.Department); 
        }
        
        
      }
public void SearchEmployee()
{
    Console.Write("\nEnter employee name: ");
    string name = Console.ReadLine();

    var result = DataStore.Employees
        .FirstOrDefault(e => e.Name.ToLower() == name.ToLower());

    if (result != null)
    {
        Console.WriteLine($"Name: {result.Name}");
        Console.WriteLine($"Department: {result.Department}");
        Console.WriteLine($"Salary: ${result.Salary}");
        Console.WriteLine($"Status: {result.Status}");
    }
    else
    {
        Console.WriteLine("Employee not found.");
    }
}
public void ExportReport()
{
    ReportExporter.ExportEmployees();
    Console.WriteLine("CSV report exported successfully.");
}
}







