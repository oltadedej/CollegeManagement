using CollegeManagementCore.Concrete;
using CollegeManagementCore.DAL;
using CollegeManagementCore.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagementCore.Service
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository = new CourseRepository();
        public void DeleteCourse(int courseID)
        {
             _courseRepository.DeleteCourse(courseID);
            _courseRepository.Save();
        }

        public Course GetCourseByID(int courseID)
        {
           return _courseRepository.GetCourseByID(courseID);
        }

        public IEnumerable<Course> GetCourses()
        {
            return _courseRepository.GetCourses();
        }

        public void InsertCourse(Course course)
        {
             _courseRepository.InsertCourse(course);
            _courseRepository.Save();
        }

      
        public void UpdateCourse(Course course)
        {
            _courseRepository.UpdateCourse(course);
            _courseRepository.Save();
        }
    }
}
