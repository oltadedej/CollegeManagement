using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CollegeManagementCore.Concrete
{
    public class Subject
    {
        public int ID { get; set; }
        [Display(Name = "Teacher ")]
        public int TeacherId { get; set; }
        [Display(Name = "Course")]
        public int CourseId { get; set; }

        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Subject Name")]
        public string SubjectName { get; set; }
        
      
        public virtual ICollection<Enrollment> Enrollments { get; set; }


    }
}