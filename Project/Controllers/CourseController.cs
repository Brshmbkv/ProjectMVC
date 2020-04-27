using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CourseController(ICourseRepository courseRepository, ICategoryRepository categoryRepository)
        {
            _courseRepository = courseRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            CoursesListViewModel coursesListViewModel = new CoursesListViewModel();
            coursesListViewModel.Courses = _courseRepository.AllCourses;
            coursesListViewModel.CurrentCategory = "Courses category";
            return View(coursesListViewModel);
        }

    }
}
