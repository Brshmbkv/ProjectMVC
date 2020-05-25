using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Project.Models;
using Project.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly AppDbContext _appDbContext;

        public CourseController(ICourseRepository courseRepository, ICategoryRepository categoryRepository, AppDbContext appDbContext)
        {
            _courseRepository = courseRepository;
            _categoryRepository = categoryRepository;
            _appDbContext = appDbContext;
        }

        //public ViewResult List()
        //{
        //    CoursesListViewModel coursesListViewModel = new CoursesListViewModel();
        //    coursesListViewModel.Courses = _courseRepository.AllCourses;
        //    coursesListViewModel.CurrentCategory = "Courses category";
        //    return View(coursesListViewModel);
        //}

        public ViewResult List(string category)
        {
            IEnumerable<Course> courses;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                courses = _courseRepository.AllCourses.OrderBy(c => c.CourseId);
                currentCategory = "All Courses";
            }
            else
            {
                courses = _courseRepository.AllCourses.Where(c => c.Category.CategoryName == category)
                    .OrderBy(c => c.CourseId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new CoursesListViewModel
            {
                Courses = courses,
                CurrentCategory = currentCategory
            });     
        }

        public IActionResult Details(int id)
        {
            var course = _courseRepository.GetCourseById(id);
            if (course == null)
                return NotFound();
            return View(course);
        }

        [Authorize(Roles ="Admin")]
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = _categoryRepository.AllCategories.Select(li => new SelectListItem
            {
                Text = li.CategoryName,
                Value = li.CategoryId.ToString()
            });
            return View();
        }

        [Authorize(Roles ="Admin")]
        [HttpPost]
        public IActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                if(!course.IsCourseOfTheWeek && course.InStock)
                {
                    course.IsCourseOfTheWeek = false;
                    course.InStock = false;
                }else if (!course.IsCourseOfTheWeek)
                {
                    course.IsCourseOfTheWeek = false;
                }
                else if (!course.InStock)
                {
                    course.InStock = false;
                }
               
                _courseRepository.Create(course);
                return RedirectToAction("Index", "Home");
            }
            return View(course);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_courseRepository.AllCourses.Where(s => s.CourseId == id).First());
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Update(Course course)
        {
            _courseRepository.Update(course);
            return RedirectToAction("Index", "Home");
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var course = _courseRepository.GetCourseById(id);
            _courseRepository.Delete(course);

            return RedirectToAction("Index", "Home");

        }
    }
}
