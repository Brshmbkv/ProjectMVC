using Microsoft.EntityFrameworkCore;
using Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class CourseRepository : ICourseRepository
    {
        private readonly AppDbContext _appDbContext;
        public CourseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Course> AllCourses
        {
            get
            {
                return _appDbContext.Courses.Include(c => c.Category);
            }
        }

        public IEnumerable<Course> CoursesOfTheWeek
        {
            get
            {
                return _appDbContext.Courses.Include(c => c.Category).Where(p => p.IsCourseOfTheWeek);
            }
        }

        public Course GetCourseById(int courseId)
        {
            return _appDbContext.Courses.FirstOrDefault(c => c.CourseId == courseId);
        }

        public void Create(Course course)
        {
            _appDbContext.Courses.Add(course);
            _appDbContext.SaveChanges();
        }

        public void Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Course course)
        {
            _appDbContext.Courses.Update(course);
            _appDbContext.SaveChangesAsync();
        }

        public void Delete(Course course)
        {
            _appDbContext.Courses.Remove(course);
            _appDbContext.SaveChanges();
        }
    }
}
