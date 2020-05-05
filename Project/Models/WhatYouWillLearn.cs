using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class WhatYouWillLearn
    {
        public int WhatYouWillLearnId { get; set; }
        public string Text { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
