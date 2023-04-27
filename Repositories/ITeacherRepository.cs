using AspNetCoreEntityFrameworkApp.Models;

namespace WebApplication123.Repositories
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAllTeachers();
        Teacher GetTeacherById(int id);
        void CreateTeacher(Teacher teacher);
        void UpdateTeacher(Teacher teacher);
        void DeleteTeacher(Teacher teacher);
    }
}
