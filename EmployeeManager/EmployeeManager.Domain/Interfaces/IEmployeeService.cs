using EmployeeManager.Domain.DTOs;

namespace EmployeeManager.Domain.Interfaces;

public interface IEmployeeService
{
    // Get all employees
    Task<List<EmployeeDto>> GetAllAsync();

    // Get a single employee by Id
    Task<EmployeeDto?> GetByIdAsync(int id);

    // Create a new employee
    Task<int> CreateAsync(EmployeeCreateDto dto);

    // Update an existing employee
    Task UpdateAsync(EmployeeEditDto dto);

    // Delete an employee by Id
    Task DeleteAsync(int id);
}
