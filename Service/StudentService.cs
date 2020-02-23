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
    public class StudentService : IStudentService
    {
        private  IStudentRepository _repos =  new StudentRepository();
        public void DeleteStudent(int studentID)
        {
            _repos.DeleteStudent(studentID);
            _repos.Save();
        }

        public Student GetStudentByID(int studentID)
        {
            return _repos.GetStudentByID(studentID);
        }

        public IEnumerable<Student> GetStudents()
        {
            return _repos.GetStudents();
        }

        public void InsertStudent(Student student)
        {
             _repos.InsertStudent(student);
            _repos.Save();
        }

        public void UpdateStudent(Student student)
        {
            _repos.UpdateStudent(student);
            _repos.Save();
        }
    }
}
