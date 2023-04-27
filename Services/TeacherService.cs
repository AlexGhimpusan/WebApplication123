using AspNetCoreEntityFrameworkApp.Models;
using NuGet.DependencyResolver;
using WebApplication123.Repositories;

namespace WebApplication123.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _teacherRepository.GetAllTeachers();
        }

        public Teacher GetTeacherById(int id)
        {
            return _teacherRepository.GetTeacherById(id);
        }

        public void CreateTeacher(Teacher teacher)
        {
            _teacherRepository.CreateTeacher(teacher);
        }

        public void DeleteTeacher(Teacher teacher)
        {
            _teacherRepository.DeleteTeacher(teacher);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _teacherRepository.UpdateTeacher(teacher);
        }
    }
}
