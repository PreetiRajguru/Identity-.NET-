using StudentTeacherDemo.Data.Models;

namespace StudentTeacherDemo.Services.Interfaces;

public interface IStudentRepository
{
    Task<Student> GetStudent(int teacherId, int studentId, bool trackChanges);
    Task CreateStudentForTeacher(int teacherId, Student student);
    Task DeleteStudent(Student student);
}
