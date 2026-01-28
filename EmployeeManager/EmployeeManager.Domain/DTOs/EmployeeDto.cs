using System.ComponentModel.DataAnnotations;

namespace EmployeeManager.Domain.DTOs;

public class EmployeeDto
{
    public int Id { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public bool IsDeveloper { get; set; }

    public int DepartmentId { get; set; }

    public string? DepartmentName { get; set; }  // optional
}

public class EmployeeCreateDto
{
    [Required(ErrorMessage = "First Name is required.")]
    [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters.")]
    public string FirstName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Last Name is required.")]
    [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters.")]
    public string LastName { get; set; } = string.Empty;

    public bool IsDeveloper { get; set; }

    [Required(ErrorMessage = "Department is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "Please select a department.")]
    public int DepartmentId { get; set; }
}

public class EmployeeEditDto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "First Name is required.")]
    [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters.")]
    public string FirstName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Last Name is required.")]
    [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters.")]
    public string LastName { get; set; } = string.Empty;

    public bool IsDeveloper { get; set; }

    [Required(ErrorMessage = "Department is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "Please select a department.")]
    public int DepartmentId { get; set; }
}
