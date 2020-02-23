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
    public class StudentViewModel
    {
        public Student Student { get; set; }
    }
}