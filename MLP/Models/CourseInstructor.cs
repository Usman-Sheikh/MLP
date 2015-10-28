using System.ComponentModel.DataAnnotations;

namespace MLP.Models
{
    public class CourseInstructor
    {
        [Key]
        public int CourseInstrucor { get; set; }

        public int InstructorId { get; set; }

        public int CourseId { get; set; }

        public int? TeacherAssitId { get; set; }

        public virtual Course Course { get; set; }

        public virtual Instructor Instructor { get; set; }

        public virtual TeacherAssistant TeacherAssistant { get; set; }
    }
}