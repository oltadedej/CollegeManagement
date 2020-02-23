using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CollegeManagementCore.DAL;
using CollegeManagementCore.Concrete;
using CollegeManagement.ViewModels;
using Microsoft.AspNet.SignalR;
using CollegeManagementCore.Service.Contract;
using CollegeManagement.EntryPoints;
using CollegeManagementCore.Service;

namespace CollegeManagement.SignalRHub
{
    public class SiteHub : Hub
    {

        // get the chat for the report
        public void Read()
        {
                 ICourseService courseService = EntryPoints<CourseService>.Service;
                var courses = courseService.GetCourses();
                foreach(var course in courses)
                {
                
                    Clients.All.readMessageToPage(course.Title, course.Credits);
                }

                   // Clients.All.readMessageToPage("tEST", "TEST");
       
        }
}
}