using System.Net.Http.Json;
using EmployeeManager.Domain.DTOs;

namespace EmployeeManager.UI.Services;

public class DepartmentApiService : IDepartmentApiService
{
    private readonly HttpClient _http;

    public DepartmentApiService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<DepartmentDto>> GetAllDepartmentsAsync()
    {
        return await _http.GetFromJsonAsync<List<DepartmentDto>>("api/departments") ?? new List<DepartmentDto>();
    }

    public async Task<DepartmentDto?> GetByIdAsync(int id)
    {
        return await _http.GetFromJsonAsync<DepartmentDto>($"api/departments/{id}");
    }

    public async Task<DepartmentDto?> GetDepartmentByIdAsync(int id)
    {
        return await _http.GetFromJsonAsync<DepartmentDto>($"api/departments/{id}");
    }

    public async Task CreateDepartmentAsync(DepartmentCreateDto dto)
    {
        await _http.PostAsJsonAsync("api/departments", dto);
    }

    public async Task UpdateDepartmentAsync(int id, DepartmentEditDto dto)
    {
        await _http.PutAsJsonAsync($"api/departments/{id}", dto);
    }

    public async Task DeleteDepartmentAsync(int id)
    {
        await _http.DeleteAsync($"api/departments/{id}");
    }
}
