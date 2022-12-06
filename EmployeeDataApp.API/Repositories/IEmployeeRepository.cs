using EmployeeDataApp.Entities;

namespace EmployeeDataApp.API.Repositories;

public interface IEmployeeRepository
{
    IEnumerable<Employee> GetAllEmployees();
}