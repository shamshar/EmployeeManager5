using EmployeeManager.Domain.DTOs;

namespace EmployeeManager.UI.Services;

public interface IDepartmentApiService
{
    Task<List<DepartmentDto>> GetAllDepartmentsAsync();
    Task<DepartmentDto?> GetByIdAsync(int id);
    Task<DepartmentDto?> GetDepartmentByIdAsync(int id);
    Task CreateDepartmentAsync(DepartmentCreateDto dto);
    Task UpdateDepartmentAsync(int id, DepartmentEditDto dto);
    Task DeleteDepartmentAsync(int id);
}
