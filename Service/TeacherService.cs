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
    public class TeacherService : ITeacherService
    {
        private ITeacherRepository _rep = new TeacherRepository();
        public void DeleteTeacher(int teacherId)
        {
            _rep.DeleteTeacher(teacherId);
            _rep.Save();
        }

        public Teacher GetTeacherById(int teacherId)
        {
            return _rep.GetTeacherById(teacherId);
        }

        public IEnumerable<Teacher> GetTeachers()
        {
            return _rep.GetTeachers();
        }

        public void InsertTeacher(Teacher teacher)
        {
            _rep.InsertTeacher(teacher);
            _rep.Save();
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _rep.UpdateTeacher(teacher);
            _rep.Save();
        }
    }
}
