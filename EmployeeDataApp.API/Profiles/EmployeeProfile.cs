using AutoMapper;
using EmployeeDataApp.API.DTOs;
using EmployeeDataApp.Entities;

namespace EmployeeDataApp.API.Profiles;

public class EmployeeProfile : Profile
{
    public EmployeeProfile()
    {
        CreateMap<Employee, EmployeeDto>();
    }
}