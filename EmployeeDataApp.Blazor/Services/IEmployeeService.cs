using EmployeeDataApp.Entities;

namespace EmployeeDataApp.Blazor.Services;

public interface IEmployeeService
{
    public Task<IEnumerable<Employee>> GetAllEmployees();
}