using EmployeeManager.Domain.DTOs;
using EmployeeManager.Domain.Entities;
using EmployeeManager.Domain.Interfaces;
using EmployeeManager.Application.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManager.Application.Services;

public class DepartmentService : IDepartmentService
{
    private readonly EmployeeManagerDbContext _db;

    public DepartmentService(EmployeeManagerDbContext db)
    {
        _db = db;
    }

    public async Task<int> CreateAsync(DepartmentCreateDto dto)
    {
        var entity = new Department { Name = dto.Name };
        _db.Departments.Add(entity);
        await _db.SaveChangesAsync();
        return entity.Id;
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _db.Departments.FindAsync(id);
        if (entity != null)
        {
            _db.Departments.Remove(entity);
            await _db.SaveChangesAsync();
        }
    }

    public async Task<List<DepartmentDto>> GetAllAsync()
    {
        return await _db.Departments
            .Select(d => new DepartmentDto
            {
                Id = d.Id,
                Name = d.Name
            })
            .ToListAsync();
    }

    public async Task<DepartmentDto?> GetByIdAsync(int id)
    {
        var d = await _db.Departments.FindAsync(id);
        if (d == null) return null;

        return new DepartmentDto { Id = d.Id, Name = d.Name };
    }

    public async Task UpdateAsync(DepartmentEditDto dto)
    {
        var entity = await _db.Departments.FindAsync(dto.Id);
        if (entity != null)
        {
            entity.Name = dto.Name;
            await _db.SaveChangesAsync();
        }
    }
}
