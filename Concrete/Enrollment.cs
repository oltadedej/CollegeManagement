using System.ComponentModel.DataAnnotations;
using static CollegeManagementCore.Utils.Enumerators;

namespace CollegeManagementCore.Concrete
{
  
    public class Enrollment
    {
        public int ID { get; set; }
        public int SubjectID { get; set; }
        public int StudentID { get; set; }

        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual Student Student { get; set; }
    }
}