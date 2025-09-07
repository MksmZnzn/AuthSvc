using AuthSvc.Application.DTOs;
using AuthSvc.Domain.Entities;
using AutoMapper;

namespace AuthSvc.Application.Mappers;

public class UserMapper : Profile
{
    public UserMapper()
    {
        CreateMap<User, UserResponseDTO>();
    }
}