using AspNetCoreEntityFrameworkApp.Models;

namespace WebApplication123.Services
{
    public interface ITeacherService
    {
        IEnumerable<Teacher> GetAllTeachers();
        Teacher GetTeacherById(int id);
        void CreateTeacher(Teacher teacher);
        void UpdateTeacher(Teacher teacher);
        void DeleteTeacher(Teacher teacher);
    }
}
