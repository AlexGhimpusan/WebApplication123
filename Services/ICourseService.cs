using AspNetCoreEntityFrameworkApp.Models;

namespace WebApplication123.Services
{
    public interface ICourseService
    {
        IEnumerable<Course> GetAllCourses();
        Course GetCourseById(int id);
        void CreateCourse(Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(Course course);
    }
}
