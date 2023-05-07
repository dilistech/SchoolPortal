using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace SchoolPortal.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        [Display(Name = "Course")]
        public int CourseId { get; set; }

        [Display(Name = "Student Id")]
        public int? StudentId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string? Grade { get; set; }
        public  Course Course { get; set; }
        public  Student Student { get; set; }
    }
}
