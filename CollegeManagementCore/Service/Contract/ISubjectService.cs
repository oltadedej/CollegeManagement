using CollegeManagementCore.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagementCore.Service.Contract
{
  public  interface ISubjectService
    {
        IEnumerable<Subject> GetSubjects();
        Subject GetSubjectById(int subjectId);
        void InsertSubject(Subject subject);
        void DeleteSubject(int subjectID);
        void UpdateSubject(Subject subject);
    }
}
