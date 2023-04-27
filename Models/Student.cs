﻿using System.Diagnostics;

namespace AspNetCoreEntityFrameworkApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public ICollection<Grade>? Grades { get; set; }
        public ICollection<StudentHomework>? StudentHomeworks { get; set; }
    }

}