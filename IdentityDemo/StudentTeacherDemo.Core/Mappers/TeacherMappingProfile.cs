using AutoMapper;
using StudentTeacherDemo.Data.Models;
using StudentTeacherDemo.Services.DTOs;

namespace StudentTeacher.Core.Mappings;

public class TeacherMappingProfile : Profile
{
    public TeacherMappingProfile()
    {
        CreateMap<Teacher, TeacherDTO>();

        CreateMap<TeacherCreationDTO, Teacher>();

        CreateMap<TeacherUpdateDTO, Teacher>().ReverseMap();
    }
}
