using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MLP.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Duration { get; set; }

        public string OutComes { get; set; }

        public int? CreditHours { get; set; }

        public virtual ICollection<CourseInstructor> CourseInstructors { get; set; }

        public virtual ICollection<Module> Modules { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}