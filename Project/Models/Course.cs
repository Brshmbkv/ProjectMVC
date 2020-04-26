using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; } 
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsCourseOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public Category Category { get; set; }
    }
}
