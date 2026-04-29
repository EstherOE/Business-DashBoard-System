public class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
    public string Status { get; set; }

    public Employee(string name, string dept, double salary, string status)
    {
        Name = name;
        Department = dept;
        Salary = salary;
        Status = status;
    }
}