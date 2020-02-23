using CollegeManagementCore.Concrete;
using CollegeManagementCore.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagementCore.DAL
{
  public  class SubjectRepository :ISubjectRepository
    {
        private SchoolContext context = new SchoolContext();

        public SubjectRepository()
        {

        }

        public IEnumerable<Subject> GetSubjects()
        {
            return context.Subjects;
        }

        public Subject GetSubjectById(int subjectId)
        {
            return context.Subjects.Find(subjectId);
        }

        public void InsertSubject(Subject subject)
        {
            context.Subjects.Add(subject);
        }

        public void DeleteSubject(int subjectId)
        {
            Subject subject = GetSubjectById(subjectId);
            context.Subjects.Remove(subject);
        }

        public void UpdateSubject(Subject subject)
        {
            context.Entry(subject).State = EntityState.Modified;
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
