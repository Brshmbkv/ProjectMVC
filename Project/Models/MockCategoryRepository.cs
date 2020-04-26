using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Web Development", Description = "Web development refers to building, creating, and an maintaining websites"},
                new Category{CategoryId = 2, CategoryName = "Mobile Apps", Description = "Mobile app development is the act or process by which a mobile app is developed for mobile devices, such as personal digital assistants, enterprise digital assistants or mobile phones" },
                new Category{CategoryId = 3, CategoryName = "Web design", Description = "Web designers use their creative and software engineering/programing skills to design, build and improve websites"}
            };
    }
}
