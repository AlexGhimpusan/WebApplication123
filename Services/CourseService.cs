using AspNetCoreEntityFrameworkApp.Models;
using WebApplication123.Repositories;

namespace WebApplication123.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _courseRepository.GetAllCourses();
        }

        public Course GetCourseById(int id)
        {
            return _courseRepository.GetCourseById(id);
        }

        public void CreateCourse(Course course)
        {
            _courseRepository.CreateCourse(course);
        }

        public void DeleteCourse(Course course)
        {
            _courseRepository.DeleteCourse(course);
        }

        public void UpdateCourse(Course course)
        {
            _courseRepository.UpdateCourse(course);
        }
    }
}
