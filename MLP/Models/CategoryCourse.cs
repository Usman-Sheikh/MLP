using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MLP.Models
{
    public class CategoryCourse
    {
        [Key]
        public int CategoryCourseId { get; set; }
        public string CategoryCourseName { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

    }
}