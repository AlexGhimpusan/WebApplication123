using AspNetCoreEntityFrameworkApp.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication123.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityContext _dbContext;

        public CourseRepository(UniversityContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _dbContext.Courses.ToList();
        }

        public Course GetCourseById(int id)
        {
            return _dbContext.Courses.Find(id);
        }

        public void CreateCourse(Course course)
        {
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();
        }

        public void UpdateCourse(Course course)
        {
            _dbContext.Entry(course).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void DeleteCourse(Course course)
        {
            _dbContext.Courses.Remove(course);
            _dbContext.SaveChanges();
        }
    }
}
