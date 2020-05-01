using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class MockCourseRepository : ICourseRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Course> AllCourses =>
            new List<Course>
            {
                new Course{CourseId = 1, Name = "The Complete JavaScript Course 2020: Build Real Projects!", Price = 20M,ShortDescription="Master JavaScript with the most complete course! Projects, challenges, quizzes, JavaScript ES6+, OOP, AJAX, Webpack", ImageUrl="https://img-a.udemycdn.com/course/240x135/851712_fc61_5.jpg",ImageThumbnailUrl="url",IsCourseOfTheWeek = true,InStock = true, Category = _categoryRepository.AllCategories.ToList()[0]},
                new Course{CourseId = 2, Name = "Modern JavaScript From The Beginning", Price = 39M,ShortDescription="Learn and build projects with pure JavaScript (No frameworks or libraries)", ImageUrl="https://img-a.udemycdn.com/course/240x135/1463348_52a4_2.jpg",ImageThumbnailUrl="url",IsCourseOfTheWeek = true,InStock = true, Category = _categoryRepository.AllCategories.ToList()[0]},
                new Course{CourseId = 3, Name = "The Complete Android N Developer Course", Price = 19M, ShortDescription="Learn Android App Development with Android 7 Nougat by building real apps including Uber, Whatsapp and Instagram!", ImageUrl="https://img-a.udemycdn.com/course/240x135/951618_0839_2.jpg",ImageThumbnailUrl="url",IsCourseOfTheWeek = true,InStock = true, Category = _categoryRepository.AllCategories.ToList()[1]},
                new Course{CourseId = 4, Name = "The easiest way to learn modern web design, HTML5 and CSS3 step-by-step from scratch. Design AND code a huge project", Price = 78M, ShortDescription = "s desc",ImageUrl="https://img-a.udemycdn.com/course/240x135/437398_46c3_9.jpg",ImageThumbnailUrl="url",IsCourseOfTheWeek = true,InStock = true,Category = _categoryRepository.AllCategories.ToList()[2]}
            };  

        public IEnumerable<Course> CoursesOfTheWeek { get; }

        public Course GetCourseById(int courseId)
        {
            return AllCourses.FirstOrDefault(p => p.CourseId == courseId);
        }
    }
}
