using System.Text.Json;
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
        return await JsonSerializer.DeserializeAsync<IEnumerable<Employee>>(await _httpClient.GetStreamAsync("api/employees"),
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }) ?? Array.Empty<Employee>();
    }
}