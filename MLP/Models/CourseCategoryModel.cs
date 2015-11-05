using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MLP.Models
{
    public class CourseCategoryModel
    {
        public List<CategoryCourse> CategoryCourseList { get; set; }
        public List<Course> CourseList { get; set; }
    }
}