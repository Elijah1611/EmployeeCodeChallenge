using System.Net.Http.Json;
using EmployeeDataApp.Entities;

namespace EmployeeDataApp.Blazor.Services;

public class EmployeeService : IEmployeeService
{

    private readonly HttpClient _httpClient;
    private readonly List<Employee> _employees;

    public EmployeeService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<IEnumerable<Employee>> GetAllEmployees()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<Employee>>("api/employees") ?? Array.Empty<Employee>();
    }
}