using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Project.ViewModels
{
    public class CoursesListViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
        public string CurrentCategory { get; set; }
    }
}
