using Microsoft.AspNetCore.Mvc.ModelBinding;
using Project.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Course
    {
        [BindNever]
        public int CourseId { get; set; }
        
        [Required]
        //[IsCourseExist]
        public string Name { get; set; }

        [Required(ErrorMessage = "Short description is required")]
        [Display(Name = "Short Description")]
        [StringLength(200)]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage ="Please enter price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Image Url is reqired")]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }
        
        [Required(ErrorMessage = "Image thumbnail Url is required")]
        [Display(Name = "Image Thumbnail URL")]
        public string ImageThumbnailUrl { get; set; }

        public bool IsCourseOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<WhatYouWillLearn> WhatYouWillLearn { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (ImageUrl.Contains("https"))
            {
                yield return ValidationResult.Success;
            }
            else
            {
                yield return new ValidationResult("Image URL must start with https!", new[] { nameof(ImageUrl) });
            }
        }

    }
}
