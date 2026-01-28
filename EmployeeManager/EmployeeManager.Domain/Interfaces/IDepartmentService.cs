using EmployeeManager.Domain.DTOs;

namespace EmployeeManager.Domain.Interfaces
{
    public interface IDepartmentService
    {
        Task<List<DepartmentDto>> GetAllAsync();
        Task<DepartmentDto?> GetByIdAsync(int id);
        Task<int> CreateAsync(DepartmentCreateDto dto);
        Task UpdateAsync(DepartmentEditDto dto);
        Task DeleteAsync(int id);
    }

}
