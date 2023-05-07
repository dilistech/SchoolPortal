using System.ComponentModel.DataAnnotations;

namespace SchoolPortal.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Matric Number")]
        public string MatricNumber { get; set; }

        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public  ICollection<Enrollment> Enrollments { get; set; }
    }
}
