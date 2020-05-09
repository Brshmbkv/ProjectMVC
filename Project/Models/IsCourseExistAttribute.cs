using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class IsCourseExistAttribute : ValidationAttribute
    {
        private readonly CourseRepository _courseRepository;

        public string getErrorMessage() => "This course is already exists!";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (_courseRepository.AllCourses.FirstOrDefault(c => c.Name ==(string)value) != null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(getErrorMessage());
        }
    }
}
