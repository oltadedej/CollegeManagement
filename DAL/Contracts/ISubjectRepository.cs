using CollegeManagementCore.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagementCore.DAL.Contracts
{
  public  interface ISubjectRepository :IDisposable
    {
        IEnumerable<Subject> GetSubjects();
        Subject GetSubjectById(int subjectId);
        void InsertSubject(Subject subject);
        void DeleteSubject(int subjectID);
        void UpdateSubject(Subject subject);
        void Save();
    }
}
