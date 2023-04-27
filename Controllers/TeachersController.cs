using AspNetCoreEntityFrameworkApp.Models;
using Microsoft.AspNetCore.Mvc;
using WebApplication123.Services;

namespace WebApplication123.Controllers
{
    public class TeachersController : Controller
    {
        private readonly ITeacherService _teacherService;

        public TeachersController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public IActionResult Index()
        {
            var teachers = _teacherService.GetAllTeachers();
            return View(teachers);
        }

        public IActionResult Details(int id)
        {
            var teacher = _teacherService.GetTeacherById(id);
            return View(teacher);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            var teacher = _teacherService.GetTeacherById(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return View(teacher);
        }

        public IActionResult Delete(int id)
        {
            var teacher = _teacherService.GetTeacherById(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return View(teacher);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Email,Phone")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _teacherService.CreateTeacher(teacher);
                return RedirectToAction(nameof(Index));
            }
            return View(teacher);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Email,Phone")] Teacher teacher)
        {
            if (id != teacher.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _teacherService.UpdateTeacher(teacher);
                return RedirectToAction(nameof(Index));
            }
            return View(teacher);
        }

        [HttpDelete, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            var teacher = _teacherService.GetTeacherById(id);
            if (teacher == null)
            {
                return NotFound();
            }

            _teacherService.DeleteTeacher(teacher);
            return RedirectToAction(nameof(Index));
        }
    }
}
