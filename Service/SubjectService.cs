using CollegeManagementCore.Concrete;
using CollegeManagementCore.DAL;
using CollegeManagementCore.DAL.Contracts;
using CollegeManagementCore.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagementCore.Service
{
    public class SubjectService : ISubjectService
    {
        private ISubjectRepository _rep = new SubjectRepository();
        public void DeleteSubject(int subjectID)
        {
            _rep.DeleteSubject(subjectID);
            _rep.Save();
        }

        public Subject GetSubjectById(int subjectId)
        {
           return _rep.GetSubjectById(subjectId);
        }

        public IEnumerable<Subject> GetSubjects()
        {
            return _rep.GetSubjects();
        }

        public void InsertSubject(Subject subject)
        {
            _rep.InsertSubject(subject);
            _rep.Save();
        }

        public void UpdateSubject(Subject subject)
        {
            _rep.UpdateSubject(subject);
            _rep.Save();
        }
    }
}
