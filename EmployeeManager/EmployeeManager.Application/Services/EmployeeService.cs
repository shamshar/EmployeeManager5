using EmployeeManager.Domain.DTOs;
using EmployeeManager.Domain.Entities;
using EmployeeManager.Domain.Interfaces;
using EmployeeManager.Application.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManager.Application.Services;

public class EmployeeService : IEmployeeService
{
    private readonly EmployeeManagerDbContext _db;

    public EmployeeService(EmployeeManagerDbContext db)
    {
        _db = db;
    }

    // Create new employee
    public async Task<int> CreateAsync(EmployeeCreateDto dto)
    {
        var entity = new Employee
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            IsDeveloper = dto.IsDeveloper,
            DepartmentId = dto.DepartmentId
        };

        _db.Employees.Add(entity);
        await _db.SaveChangesAsync();
        return entity.Id;
    }

    // Delete employee by Id
    public async Task DeleteAsync(int id)
    {
        var employee = await _db.Employees.FindAsync(id);
        if (employee != null)
        {
            _db.Employees.Remove(employee);
            await _db.SaveChangesAsync();
        }
    }

    // Get all employees
    public async Task<List<EmployeeDto>> GetAllAsync()
    {
        return await _db.Employees
            .Include(e => e.Department)
            .Select(e => new EmployeeDto
            {
                Id = e.Id,
                FirstName = e.FirstName,
                LastName = e.LastName,
                IsDeveloper = e.IsDeveloper,
                DepartmentId = e.DepartmentId,
                DepartmentName = e.Department!.Name
            })
            .ToListAsync();
    }

    // Get single employee by Id
    public async Task<EmployeeDto?> GetByIdAsync(int id)
    {
        var e = await _db.Employees
            .Include(e => e.Department)
            .FirstOrDefaultAsync(e => e.Id == id);

        if (e == null) return null;

        return new EmployeeDto
        {
            Id = e.Id,
            FirstName = e.FirstName,
            LastName = e.LastName,
            IsDeveloper = e.IsDeveloper,
            DepartmentId = e.DepartmentId,
            DepartmentName = e.Department!.Name
        };
    }

    // Update employee
    public async Task UpdateAsync(EmployeeEditDto dto)
    {
        var employee = await _db.Employees.FindAsync(dto.Id);
        if (employee == null) return;

        employee.FirstName = dto.FirstName;
        employee.LastName = dto.LastName;
        employee.IsDeveloper = dto.IsDeveloper;
        employee.DepartmentId = dto.DepartmentId;

        await _db.SaveChangesAsync();
    }
}
