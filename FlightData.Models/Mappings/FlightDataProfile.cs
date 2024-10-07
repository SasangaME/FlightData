using AutoMapper;
using FlightData.Models.Dto;
using FlightData.Models.Entities;

namespace FlightData.Models.Mappings;

public class FlightDataProfile : Profile
{
    public FlightDataProfile()
    {
        CreateMap<Role, RoleDto>().ReverseMap();
    }
}