using System.IO;

public static class ReportExporter
{
    public static void ExportEmployees()
    {
        using (StreamWriter writer = new StreamWriter("employees_report.csv"))
        {
            writer.WriteLine("Name,Department,Salary,Status");

            foreach (var emp in DataStore.Employees)
            {
                writer.WriteLine($"{emp.Name},{emp.Department},{emp.Salary},{emp.Status}");
            }
        }
    }
}