using AspNetCoreEntityFrameworkApp.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication123.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly UniversityContext _dbContext;

        public StudentRepository(UniversityContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _dbContext.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return _dbContext.Students.Find(id);
        }

        public void CreateStudent(Student student)
        {
            _dbContext.Students.Add(student);
            _dbContext.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            _dbContext.Entry(student).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void DeleteStudent(Student student)
        {
            _dbContext.Students.Remove(student);
            _dbContext.SaveChanges();
        }
    }
}
