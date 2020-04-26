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
                new Course{CourseId = 1, Name = "The Complete JavaScript Course 2020: Build Real Projects!", Price = 20M,ShortDescription="s desc", LongDescription = "l desc", ImageUrl="url",ImageThumbnailUrl="url",IsCourseOfTheWeek = true,InStock = true, Category = _categoryRepository.AllCategories.ToList()[0]},
                new Course{CourseId = 2, Name = "Modern JavaScript From The Beginning", Price = 39M,ShortDescription="s desc", LongDescription = "l desc", ImageUrl="url",ImageThumbnailUrl="url",IsCourseOfTheWeek = true,InStock = true, Category = _categoryRepository.AllCategories.ToList()[0]},
                new Course{CourseId = 3, Name = "The Complete Android N Developer Course", Price = 19M, ShortDescription="s desc", LongDescription = "l desc", ImageUrl="url",ImageThumbnailUrl="url",IsCourseOfTheWeek = true,InStock = true, Category = _categoryRepository.AllCategories.ToList()[1]},

            };
    }
}
