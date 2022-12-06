using AutoMapper;
using EmployeeDataApp.API.DTOs;
using EmployeeDataApp.API.Repositories;
using EmployeeDataApp.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDataApp.API.Controllers;

[ApiController]
[Route("api/employees")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;

    public EmployeeController(IEmployeeRepository employeeRepository, IMapper mapper)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
    }
    
    [HttpGet]
    public IActionResult GetAllEmployees()
    {
        var employeeEntities = _employeeRepository.GetAllEmployees();
        return Ok(_mapper.Map<IEnumerable<EmployeeDto>>(employeeEntities));
    }
}