using System;

class Dashboard
{
    public void ShowKPIs()
    {
        Console.WriteLine("\n--- KPI Summary ---");
        Console.WriteLine("Total Sales: $120,000");
        Console.WriteLine("Total Staff: 48");
        Console.WriteLine("Customers: 920");
        Console.WriteLine("Monthly Revenue: $18,500");
    }

    public void ShowDepartments()
    {
        Console.WriteLine("\n--- Departments ---");
        Console.WriteLine("Sales");
        Console.WriteLine("HR");
        Console.WriteLine("IT");
        Console.WriteLine("Operations");
    }

    public void SearchEmployee()
    {
        Console.Write("\nEnter employee name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"{name} found in Operations.");
    }

    public void ExportReport()
    {
        Console.WriteLine("\nReport exported successfully.");
    }
}







