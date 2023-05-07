using System.ComponentModel.DataAnnotations;

namespace SchoolPortal.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Display(Name = "Department Name")]
        public string Title { get; set; }

        public ICollection<Course> Courses { get; set; }
        public ICollection<Student> Students { get; set; }
        
    }
}
