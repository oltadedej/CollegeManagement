using CollegeManagement.EntryPoints;
using CollegeManagementCore.Concrete;
using CollegeManagementCore.Service;
using CollegeManagementCore.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeManagement.ViewModels
{
    public class SubjectViewModel
    {
        public Subject Subject { get; set; }
        public List<SelectListItem> listTeachers { get; set; }
        public List<SelectListItem> listCourses { get; set; }
        public SubjectViewModel()
        {
            listTeachers = GetListSelectedItemsFromTeachers();
            listCourses = GetListSelectedItemsFromCourses();
        }
        public List<SelectListItem> GetListSelectedItemsFromTeachers(

     string defaultOptionText = null
     )
        {
            List<SelectListItem> list = new List<SelectListItem>();
            ITeacherService srv = EntryPoints<TeacherService>.Service;
            var listTeachers =srv.GetTeachers() ;
            foreach (var teacher in listTeachers)
            {
                SelectListItem sli = new SelectListItem { Value = teacher.ID.ToString(), Text = teacher.FullName };
                list.Add(sli);
            }

            return list;
        }
        public List<SelectListItem> GetListSelectedItemsFromCourses(

   string defaultOptionText = null
   )
        {
            List<SelectListItem> list = new List<SelectListItem>();
            ICourseService srv = EntryPoints<CourseService>.Service;
            var listCourses = srv.GetCourses();
            foreach (var course in listCourses)
            {
                SelectListItem sli = new SelectListItem { Value = course.ID.ToString(), Text = course.Title };
                list.Add(sli);
            }

            return list;
        }
    }
}