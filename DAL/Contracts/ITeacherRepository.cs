using CollegeManagementCore.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagementCore.DAL
{
  public  interface ITeacherRepository :IDisposable
    {
        IEnumerable<Teacher> GetTeachers();
        Teacher GetTeacherById(int teacherId);
        void InsertTeacher(Teacher teacher);
        void DeleteTeacher(int teacherId);
        void UpdateTeacher(Teacher teacher);
        void Save();
    }
}
