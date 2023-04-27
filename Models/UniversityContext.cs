using Microsoft.EntityFrameworkCore;

namespace AspNetCoreEntityFrameworkApp.Models
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options) { }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<TeacherCourse> TeacherCourses { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<StudentHomework> StudentHomeworks { get; set; }
    }
}
