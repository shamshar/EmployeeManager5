using EmployeeManager.Domain.DTOs;

namespace EmployeeManager.UI.Services;

public interface IEmployeeApiService
{
    Task<List<EmployeeDto>> GetAllEmployeesAsync();
    Task<EmployeeEditDto?> GetEmployeeByIdAsync(int id);
    Task<EmployeeDto?> GetByIdAsync(int id);

    Task CreateEmployeeAsync(EmployeeCreateDto employee); // <-- Use CreateDto
    Task UpdateEmployeeAsync(int id, EmployeeEditDto dto);
    Task DeleteEmployeeAsync(int id);
}

