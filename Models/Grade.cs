namespace AspNetCoreEntityFrameworkApp.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }

}
