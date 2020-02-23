using CollegeManagementCore.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagementCore.DAL
{
   public class TeacherRepository :ITeacherRepository
    {
        private SchoolContext context = new SchoolContext();

        public TeacherRepository()
        {

        }

        public IEnumerable<Teacher> GetTeachers()
        {
            return context.Teachers;
        }

        public Teacher GetTeacherById(int teacherId)
        {
            return context.Teachers.Find(teacherId);
        }

        public void InsertTeacher(Teacher teacher)
        {
            context.Teachers.Add(teacher);
        }

        public void DeleteTeacher(int teacherId)
        {
            Teacher teacher = GetTeacherById(teacherId);
            context.Teachers.Remove(teacher);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            context.Entry(teacher).State = EntityState.Modified;
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
