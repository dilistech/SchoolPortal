using System.ComponentModel.DataAnnotations;

namespace SchoolPortal.Models
{
    public class Lecturer
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Display(Name = "Course Id")]
        public int CourseId { get; set; }

        public Course Course { get; set; }

        
    }
}
