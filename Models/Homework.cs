namespace AspNetCoreEntityFrameworkApp.Models
{
    public class Homework
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Course Course { get; set; }
        public ICollection<StudentHomework> StudentHomeworks { get; set; }
    }

}
