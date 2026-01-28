using System.Net.Http.Json;
using EmployeeManager.Domain.DTOs;

namespace EmployeeManager.UI.Services
{
    public class EmployeeApiService : IEmployeeApiService
    {
        private readonly HttpClient _http;

        public EmployeeApiService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<EmployeeDto>> GetAllEmployeesAsync()
        {
            return await _http.GetFromJsonAsync<List<EmployeeDto>>("api/employees")
                   ?? new List<EmployeeDto>();
        }

        public async Task<EmployeeEditDto?> GetEmployeeByIdAsync(int id)
        {
            return await _http.GetFromJsonAsync<EmployeeEditDto>($"api/employees/{id}");
        }

        public async Task CreateEmployeeAsync(EmployeeCreateDto dto)
        {
            await _http.PostAsJsonAsync("api/employees", dto);
        }

        public async Task UpdateEmployeeAsync(int id, EmployeeEditDto dto)
        {
            await _http.PutAsJsonAsync($"api/employees/{id}", dto);
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            await _http.DeleteAsync($"api/employees/{id}");
        }

        public async Task<EmployeeDto?> GetByIdAsync(int id)
        {
            return await _http.GetFromJsonAsync<EmployeeDto>($"api/employees/{id}");
        }

    }
}
