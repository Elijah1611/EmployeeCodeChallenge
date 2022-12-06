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
    public IActionResult GetAllEmployees([FromQuery] bool adapter)
    {
        var employeeEntities = _employeeRepository.GetAllEmployees();
        
        if (adapter)
        {
            var employees = _mapper.Map<IEnumerable<EmployeeDto>>(employeeEntities);
            return Ok(new { result = employees, count = employees.Count() });
        }
        
        return Ok(_mapper.Map<IEnumerable<EmployeeDto>>(employeeEntities));
    }
}