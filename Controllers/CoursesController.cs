using AspNetCoreEntityFrameworkApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication123.Services;

namespace WebApplication123.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            var courses = _courseService.GetAllCourses();
            return View(courses);
        }

        public IActionResult Details(int id)
        {
            var course = _courseService.GetCourseById(id);
            return View(course);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,StudyYear,Announcements")] Course course)
        {
            if (ModelState.IsValid)
            {
                _courseService.CreateCourse(course);
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        public IActionResult Edit(int id)
        {
            var course = _courseService.GetCourseById(id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,StudyYear,Announcements")] Course course)
        {
            if (id != course.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _courseService.UpdateCourse(course);
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        public IActionResult Delete(int id)
        {
            var course = _courseService.GetCourseById(id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        [HttpDelete, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id, IFormCollection collection)
        {
            var course = _courseService.GetCourseById(id);
            if (course == null)
            {
                return NotFound();
            }

            _courseService.DeleteCourse(course);
            return RedirectToAction(nameof(Index));
        }
    }

}
