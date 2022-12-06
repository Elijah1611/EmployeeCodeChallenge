using EmployeeDataApp.Entities;

namespace EmployeeDataApp.API.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    public IEnumerable<Employee> GetAllEmployees()
    {
        return Enumerable.Range(1, 50).Select(index => new Employee()
            {
                EmployeeId = index,
                FirstName = Faker.Name.First(),
                LastName = Faker.Name.Last(),
                Email = Faker.Internet.Email(),
                PhoneNumber = Faker.Phone.Number(),
                StreetAddress = Faker.Address.StreetAddress(),
                City = Faker.Address.City(),
                State = Faker.Address.UsState(),
                ZipCode = Faker.Address.ZipCode(),
                Country = "United States of America"
            })
            .ToArray();
    }
}