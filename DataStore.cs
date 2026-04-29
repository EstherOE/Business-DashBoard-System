using System.Collections.Generic;

public static class DataStore
{
    public static List<Employee> Employees = new List<Employee>()
    {
        new Employee("Esther", "Operations", 5000, "Active"),
        new Employee("John", "IT", 6200, "Active"),
        new Employee("Sarah", "HR", 4800, "Leave"),
        new Employee("David", "Sales", 7000, "Active"),
        new Employee("Grace", "Finance", 6500, "Active")
    };
}