﻿using AspNetCoreEntityFrameworkApp.Models;

namespace WebApplication123.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);
        void CreateStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(Student student);
    }
}
