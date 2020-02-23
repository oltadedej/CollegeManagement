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
    public class CourseViewModel
    {
        public Course Course { get; set; }
        public List<SelectListItem> listSubjects { get; set; }
        public string  SubjectID { get; set; }
        public CourseViewModel()
        {
            listSubjects = GetListSelectedItemsFromSubjects();
        }
        public List<SelectListItem> GetListSelectedItemsFromSubjects(

     string defaultOptionText = null
     )
        {
            List<SelectListItem> list = new List<SelectListItem>();
            ISubjectService srv = EntryPoints<SubjectService>.Service;
            var listSubjects =srv.GetSubjects() ;
            foreach (var subject in listSubjects)
            {
                SelectListItem sli = new SelectListItem { Value = subject.ID.ToString(), Text = subject.SubjectName };
                list.Add(sli);
            }

            return list;
        }

    }
}