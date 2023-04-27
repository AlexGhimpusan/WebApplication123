using AspNetCoreEntityFrameworkApp.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication123.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly UniversityContext _dbContext;

        public TeacherRepository(UniversityContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _dbContext.Teachers.ToList();
        }

        public Teacher GetTeacherById(int id)
        {
            return _dbContext.Teachers.Find(id);
        }

        public void CreateTeacher(Teacher teacher)
        {
            _dbContext.Teachers.Add(teacher);
            _dbContext.SaveChanges();
        }

        public void UpdateTeacher(Teacher teacher) 
        {
            _dbContext.Entry(teacher).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void DeleteTeacher(Teacher teacher)
        {
            _dbContext.Teachers.Remove(teacher);
            _dbContext.SaveChanges();
        }
    }
}
