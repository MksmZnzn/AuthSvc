using AuthSvc.Application.DTOs;
using AuthSvc.Domain.Entities;
using AutoMapper;

namespace AuthSvc.Application.Mappers;

public class RoleMapper : Profile
{
    public RoleMapper()
    {
        CreateMap<Role, RoleResponseDTO>();
    }
}