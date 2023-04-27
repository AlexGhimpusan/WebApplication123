namespace AspNetCoreEntityFrameworkApp.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public ICollection<TeacherCourse>? TeacherCourses { get; set; }
    }

}
