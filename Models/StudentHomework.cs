namespace AspNetCoreEntityFrameworkApp.Models
{
    public class StudentHomework
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Homework Homework { get; set; }
    }

}
