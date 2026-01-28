namespace EmployeeManager.Domain.Entities;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public bool IsDeveloper { get; set; }
    public int DepartmentId { get; set; }

    public Department? Department { get; set; }
}

