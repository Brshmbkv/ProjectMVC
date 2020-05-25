using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public interface ICourseRepository
    {
        IEnumerable<Course> AllCourses { get; }
        IEnumerable<Course> CoursesOfTheWeek { get; }
        Course GetCourseById(int courseId);

        void Create(Course course);
        void Read(int id);
        void Update(Course course);
        void Delete(Course course);
    }
}

