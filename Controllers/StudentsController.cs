using AspNetCoreEntityFrameworkApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication123.Services;

namespace WebApplication123.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            var students = _studentService.GetAllStudents();
            return View(students);
        }

        public IActionResult Details(int id)
        {
            var student = _studentService.GetStudentById(id);
            return View(student);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        public IActionResult Delete(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Email,Phone")] Student student)
        {
            if (ModelState.IsValid)
            {
                _studentService.CreateStudent(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Email,Phone")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _studentService.UpdateStudent(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        [HttpDelete, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }

            _studentService.DeleteStudent(student);
            return RedirectToAction(nameof(Index));
        }
    }
}
