using AutoMapper;
using EmployeeDataApp.API.DTOs;
using EmployeeDataApp.Entities;

namespace EmployeeDataApp.API.Profiles;

public class AddressProfile : Profile
{
    public AddressProfile()
    {
        CreateMap<Address, AddressDto>();
    }
}