
using System;

class Program
{
    static void Main()
    {
        Dashboard dashboard = new Dashboard();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Business Dashboard System ===");
            Console.WriteLine("1. KPI Summary");
            Console.WriteLine("2. Department Report");
            Console.WriteLine("3. Search Employee");
            Console.WriteLine("4. Export Report");
            Console.WriteLine("5. Exit");
            Console.Write("Select Option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    dashboard.ShowKPIs();
                    break;
                case "2":
                    dashboard.ShowDepartments();
                    break;
                case "3":
                    dashboard.SearchEmployee();
                    break;
                case "4":
                    dashboard.ExportReport();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.WriteLine("\nPress Enter...");
            Console.ReadLine();
        }
    }
}