using AutoMapper;
using StudentTeacherDemo.Data.Models;
using StudentTeacherDemo.Services.DTOs;

namespace StudentTeacher.Core.Mappings;
public class StudentMappingProfile : Profile
{
    public StudentMappingProfile()
    {
        CreateMap<Student, StudentDTO>();

        CreateMap<StudentCreationDTO, Student>();

        CreateMap<StudentUpdateDTO, Student>().ReverseMap();
    }
}
