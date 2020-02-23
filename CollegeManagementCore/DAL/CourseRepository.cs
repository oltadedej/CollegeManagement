using CollegeManagementCore.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagementCore.DAL
{
  public  class CourseRepository :ICourseRepository
    {
        private SchoolContext context;
        public CourseRepository()
        {
            this.context = new SchoolContext();
        }

        public IEnumerable<Course> GetCourses()
        {
            return context.Courses;
        }

        public Course GetCourseByID(int courseID)
        {
            return context.Courses.Find(courseID);
        }

        public void InsertCourse(Course course)
        {
            context.Courses.Add(course);
        }

        public void DeleteCourse(int courseID)
        {
            Course course = GetCourseByID(courseID);
            context.Courses.Remove(course);
        }

        public void UpdateCourse(Course course)
        {
            
            context.Entry(course).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
