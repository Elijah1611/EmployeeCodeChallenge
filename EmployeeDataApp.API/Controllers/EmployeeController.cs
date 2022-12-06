using EmployeeDataApp.Blazor.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDataApp.API.Controllers;

[ApiController]
[Route("api/employees")]
public class EmployeeController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Employee>> GetAllEmployees()
    {
        return Ok(Enumerable.Range(1, 50).Select(index => new Employee()
            {
                EmployeeId = index,
                FirstName = Faker.Name.First(),
                LastName = Faker.Name.Last(),
                Email = Faker.Internet.Email(),
                PhoneNumber = Faker.Phone.Number(),
                Address = new Address()
                {
                    Street = Faker.Address.StreetAddress(),
                    City = Faker.Address.City(),
                    State = Faker.Address.UsState(),
                    ZipCode = Faker.Address.ZipCode(),
                    Country = "United States of America"
                }
            })
            .ToArray());
    }
}