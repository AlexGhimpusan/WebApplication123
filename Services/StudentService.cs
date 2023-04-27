using AspNetCoreEntityFrameworkApp.Models;
using WebApplication123.Repositories;

namespace WebApplication123.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }

        public Student GetStudentById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }

        public void CreateStudent(Student student)
        {
            _studentRepository.CreateStudent(student);
        }

        public void DeleteStudent(Student student)
        {
            _studentRepository.DeleteStudent(student);
        }

        public void UpdateStudent(Student student)
        {
            _studentRepository.UpdateStudent(student);
        }
    }
}
