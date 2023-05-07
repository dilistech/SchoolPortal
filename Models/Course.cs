using System.ComponentModel.DataAnnotations;

namespace SchoolPortal.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Display(Name = "Course Title")]
        public string Title { get; set; }

        [Display(Name = "Unit Load")]
        public int UnitLoad { get; set; }

        [Display(Name = "Course Code")]
        public string CourseCode { get; set; }

        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }


    }
}
