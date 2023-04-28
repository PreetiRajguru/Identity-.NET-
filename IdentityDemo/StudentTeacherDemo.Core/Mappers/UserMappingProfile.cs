using AutoMapper;
using StudentTeacherDemo.Data.DTOs;
using StudentTeacherDemo.Data.Models;

namespace StudentTeacher.Core.Mappings;
public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<UserRegistrationDTO, User>();
    }
}
