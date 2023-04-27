using System.Diagnostics;

namespace AspNetCoreEntityFrameworkApp.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? StudyYear { get; set; }
        public string? Announcements { get; set; }
        public ICollection<TeacherCourse>? TeacherCourses { get; set; }
        public ICollection<Homework>? Homeworks { get; set; }
        public ICollection<Grade>? Grades { get; set; }
    }

}
