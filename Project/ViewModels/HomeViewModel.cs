using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Course> CoursesOfTheWeek { get; set; }
    }
}
