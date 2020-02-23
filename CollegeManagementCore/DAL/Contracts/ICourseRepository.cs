using CollegeManagementCore.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagementCore.DAL
{
 public   interface ICourseRepository : IDisposable
    {
        IEnumerable<Course> GetCourses();
        Course GetCourseByID(int courseID);
        void InsertCourse(Course course);
        void DeleteCourse(int courseID);
        void UpdateCourse(Course course);
        void Save();
    }
}
